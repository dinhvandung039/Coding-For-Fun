namespace Adapter_Wrapper_Pattern.Adapters
{
    public interface IRecipesApi
    {
        Task<string> MakeHttpRequestForRecipe(string recipe);
    }
}
