using System.Collections.Generic;
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
                new RecipeServiceModel {RecipeId = 1, Name = "Soup"},
            };
        }
    }
}
