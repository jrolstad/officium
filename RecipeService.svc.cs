using System.Collections.Generic;
using officium.Models;

namespace officium
{
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
