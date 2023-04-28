namespace Adapter_Wrapper_Pattern.Adapters
{
    public interface IAdaptsRecipesToJson
    {
        Task<string> GetRecipeAsJson(string recipeName);
    }
}
