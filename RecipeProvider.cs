using System.Collections.Generic;
using System.Linq;
using officium.ServiceModels;

namespace officium
{
    public class RecipeProvider
    {
        public IQueryable<RecipeServiceModel> Recipes()
        {
            return new List<RecipeServiceModel>
            {
                new RecipeServiceModel {RecipeId = 1, Name = "Burger"},
                new RecipeServiceModel {RecipeId = 2, Name = "Soup"},
                new RecipeServiceModel {RecipeId = 3, Name = "Lamb Stew"},
                new RecipeServiceModel {RecipeId = 4, Name = "Pot Pie"},
                new RecipeServiceModel {RecipeId = 5, Name = "Lime Couscous"},
            }
            .AsQueryable();
        }
    }
}