using System.Data.Entity;
using officium.DataModels;

namespace officium.EntityFramework
{
    public class OfficiumContextInitializer : CreateDatabaseIfNotExists<OfficiumContext>
    {
        protected override void Seed(OfficiumContext context)
        {
            context.Recipes.Add(CreateNewRecipe(1, "Foo"));
            context.Recipes.Add(CreateNewRecipe(2, "Soup"));
            context.Recipes.Add(CreateNewRecipe(3, "Lamb"));
            context.Recipes.Add(CreateNewRecipe(4, "Pie"));
            context.Recipes.Add(CreateNewRecipe(5, "Couscous"));
        }

        private static Recipe CreateNewRecipe(int id, string name)
        {
            return new Recipe {RecipeId = id,Name=name};
        }
    }
}