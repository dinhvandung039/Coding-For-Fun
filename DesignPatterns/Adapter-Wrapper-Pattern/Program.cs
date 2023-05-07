using Adapter_Wrapper_Pattern.Adapters;
using RealisticDependencies.Implementations;


/// Here we use the Adapter Pattern to adapt the XML result we receive from the RecipesApi
/// to work with our client-side code, which "only works" with JSON.  Here we gain the benefit
/// of allowing the API dependency to just continue working as it needs to while changing the
/// interface of our Adapter to match what's needed here in the client.
/// 
/// Complexity: 1
/// Popularity: 3
var logger = new ConsoleLogger();

logger.LogInfo("👩‍🍳  Aggregating Recipes from the API...");

// The RecipesAPI Produces XML results
var recipesApi = new RecipesApi(logger);

// Let's adapt it with our RecipeFinder adapter to produce JSON instead
var recipeFinder = new RecipeFinder(recipesApi);

var mashedPotatoesResult = recipeFinder.GetRecipeAsJson("mashed_potatoes");
var greenBeansResult = recipeFinder.GetRecipeAsJson("green_beans");
var redCurryResult = recipeFinder.GetRecipeAsJson("red_curry");

var tasks = new List<Task<string>> { mashedPotatoesResult, greenBeansResult, redCurryResult };

await Task.WhenAll(tasks);

// We only want to work with JSON in this client
PrintJsonRecipes(tasks);

void PrintJsonRecipes(IEnumerable<Task<string>> recipes)
{
    var logger = new ConsoleLogger();
    foreach (var recipe in recipes)
    {
        logger.LogInfo(recipe.Result);
    }
}