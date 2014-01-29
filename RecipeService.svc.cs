using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using officium.DataModels;
using officium.EntityFramework;
using officium.ServiceModels;

namespace officium
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RecipeService : IRecipeService
    {
        private readonly OfficiumContext _dataContext;

        public RecipeService():this(new OfficiumContext())
        {
            
        }

        public RecipeService(OfficiumContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<RecipeServiceModel> GetAllRecipes()
        {
            var recipeModels = _dataContext.Recipes
                .Select(Map)
                .ToList();
            return recipeModels;
        }

        public RecipeServiceModel GetRecipe(string recipeId)
        {
            var recipeIdAsInt = ParseRecipeId(recipeId);

            var matchingRecipe = _dataContext.Recipes
                .FirstOrDefault(recipe => recipe.RecipeId == recipeIdAsInt);

            var recipeModel = Map(matchingRecipe);

            return recipeModel;
        }

        private static int ParseRecipeId(string recipeId)
        {
            int recipeIdAsInt;
            if (!int.TryParse(recipeId, out recipeIdAsInt))
                throw new ArgumentException("Invalid recipeId; The value needs to be an integer.");

            return recipeIdAsInt;
        }

        private static RecipeServiceModel Map(Recipe recipe)
        {
            if (recipe == null)
                return null;

            return new RecipeServiceModel {RecipeId = recipe.RecipeId, Name = recipe.Name};
        }
    }
}
