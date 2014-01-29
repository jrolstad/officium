using System.Data.Entity;
using officium.DataModels;

namespace officium.EntityFramework
{
    public class OfficiumContextInitializer : CreateDatabaseIfNotExists<OfficiumContext>
    {
        protected override void Seed(OfficiumContext context)
        {
            context.Recipes.Add(CreateNewRecipe("Foo"));
            context.Recipes.Add(CreateNewRecipe("Soup"));
            context.Recipes.Add(CreateNewRecipe("Lamb"));
            context.Recipes.Add(CreateNewRecipe("Pie"));
            context.Recipes.Add(CreateNewRecipe("Couscous"));
        }

        private static Recipe CreateNewRecipe(string name)
        {
            return new Recipe {Name=name};
        }
    }
}