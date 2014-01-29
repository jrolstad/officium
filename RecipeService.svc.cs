using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using officium.ServiceModels;

namespace officium
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RecipeService : IRecipeService
    {
        public List<RecipeServiceModel> GetAllRecipes()
        {
            return new List<RecipeServiceModel>
            {
                new RecipeServiceModel {RecipeId = 1, Name = "Burger"},
                new RecipeServiceModel {RecipeId = 2, Name = "Soup"},
            };
        }

        public RecipeServiceModel GetRecipe(string recipeId)
        {
            int recipeIdAsInt;
            if(!int.TryParse(recipeId,out recipeIdAsInt))
                throw new ArgumentException("Invalid recipeId; The value needs to be an integer.");

            var matchingRecipe = GetAllRecipes()
                .FirstOrDefault(recipe => recipe.RecipeId == recipeIdAsInt);

            return matchingRecipe;
        }
    }
}
