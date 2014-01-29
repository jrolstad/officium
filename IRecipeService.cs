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
        [WebGet(UriTemplate ="/Recipe",ResponseFormat = WebMessageFormat.Json)]
        List<RecipeServiceModel> GetAllRecipes();

        [OperationContract]
        [WebGet(UriTemplate = "/Recipe/{recipeId}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        RecipeServiceModel GetRecipe(string recipeId);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Recipe",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json)]
        RecipeServiceModel AddRecipe(string name);
    }
}
