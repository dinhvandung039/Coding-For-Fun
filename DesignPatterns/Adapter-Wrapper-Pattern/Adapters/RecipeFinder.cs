using Newtonsoft.Json;
using System.Xml;

namespace Adapter_Wrapper_Pattern.Adapters
{
    public class RecipeFinder : IAdaptsRecipesToJson
    {
        private readonly IRecipesApi _recipesApi;

        public RecipeFinder(IRecipesApi recipesApi)
        {
            _recipesApi = recipesApi;
        }
        public async Task<string> GetRecipeAsJson(string recipeName)
        {
            var recipeXml = await _recipesApi.MakeHttpRequestForRecipe(recipeName);
            var doc = new XmlDocument();
            doc.LoadXml(recipeXml);
            var jsonResult = JsonConvert.SerializeXmlNode(doc);
            return jsonResult;
        }
    }
}
