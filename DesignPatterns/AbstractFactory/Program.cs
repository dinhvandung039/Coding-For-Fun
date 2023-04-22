using AbstractFactory.Implementations;
using AbstractFactory.Interfaces;
using RealisticDependencies.Implementations;
using RealisticDependencies.Interfaces;

var logger = new ConsoleLogger();

logger.LogInfo("Please enter customer email.");

var customerEmail = Console.ReadLine();

if (string.IsNullOrEmpty(customerEmail))
{
    logger.LogInfo("Error reading customer email.");
}

try
{
    var dietType = GetCustomerDietFromDatabase(customerEmail);
    var mealPlanFactory = GetFactoryForDietType(dietType, logger);

    ISendEmail emailer = new Emailer(logger);
    IMealPlanService mealPlanService = new MealPlanService(mealPlanFactory, emailer, logger);
    await mealPlanService.SendMealPlanToSubscriber(customerEmail);
}
catch (Exception)
{

    throw;
}

static string GetCustomerDietFromDatabase(string customerEmail) => customerEmail == "jane@gmail.com" ? "keto" : "vegetarian";

static IMealPlanFactory GetFactoryForDietType(string dietType, IApplicationLogger logger) =>
    dietType switch
    {
        "keto" => new KetoMealPlanFactory(logger),
        "vegetarian" => new VegetarianMealPlanFactory(logger),
        _ => new VegetarianMealPlanFactory(logger)
    }; ;