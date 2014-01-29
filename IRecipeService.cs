using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using officium.ServiceModels;

namespace officium
{
    [ServiceContract]
    public interface IRecipeService
    {
        [OperationContract]
        [WebGet(UriTemplate ="/Recipes")]
        List<RecipeServiceModel> GetAllRecipes();
    }
}
