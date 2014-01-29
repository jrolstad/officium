using System.Linq;
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

        public IQueryable<RecipeServiceModel> Recipes()
        {
            return _dataContext.Recipes
                .Select(r => new RecipeServiceModel {RecipeId = r.RecipeId, Name = r.Name})
            .AsQueryable();
        }
    }
}