using AbstractFactory.Interfaces;
using RealisticDependencies.Interfaces;

namespace AbstractFactory.Implementations
{
    public class MealPlanService : IMealPlanService
    {
        private readonly IMealPlanFactory _mealPlanFactory;
        private readonly ISendEmail _email;
        private readonly IApplicationLogger _logger;

        public MealPlanService(IMealPlanFactory mealPlanFactory, ISendEmail email, IApplicationLogger logger)
        {
            _mealPlanFactory = mealPlanFactory;
            _email = email;
            _logger = logger;
        }

        public async Task SendMealPlanToSubscriber(string subscribeEmail)
        {
            _logger.LogInfo("-----------------");
            var lunchMenu = _mealPlanFactory.GenerateLunchMenu();
            var dessertMenu = _mealPlanFactory.GenerateDessertMenu();
            var shoppingList = _mealPlanFactory.GenerateShoppingList();

            lunchMenu.PrintDescription();
            _logger.LogInfo($"Lunch Menu for subscriber: {subscribeEmail}");
            lunchMenu.PrintMenu();

            dessertMenu.PrintDescription();
            _logger.LogInfo($"Dessert Menu for subscriber: {subscribeEmail}");
            dessertMenu.PrintMenu();

            var ingredients = shoppingList.MakeShoppingList();

            var emailBody = string.Join(",", ingredients);
            var message = new EmailMessage(subscribeEmail, emailBody);

            _logger.LogInfo("Sending Email", ConsoleColor.Cyan);
            await _email.SendMessage(message);

            _logger.LogInfo("----------------------");
        }
    }
}
