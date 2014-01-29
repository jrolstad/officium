using System.Linq;
using officium.DataModels;
using officium.EntityFramework;
using officium.ServiceModels;

namespace officium
{
    public class RecipeProvider
    {
        private readonly OfficiumContext _dataContext;

        public RecipeProvider(OfficiumContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<Recipe> Recipes()
        {
            return _dataContext.Recipes;
        }
    }
}