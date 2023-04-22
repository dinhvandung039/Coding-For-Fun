using AbstractFactory.Interfaces;
using RealisticDependencies.Interfaces;

namespace AbstractFactory.Implementations
{
    public class KetoMealPlanFactory : IMealPlanFactory
    {
        private readonly IApplicationLogger _logger;

        public KetoMealPlanFactory(IApplicationLogger logger)
        {
            _logger = logger;
        }

        public IMenu GenerateDessertMenu()
        {
            _logger.LogInfo("Generate a Keto Dessert Menu");
            return new KetoDessertMenu();
        }

        public IMenu GenerateLunchMenu()
        {
            _logger.LogInfo("Generate a Keto Lunch Menu");
            return new KetoLunchMenu();
        }

        public IShoppingList GenerateShoppingList()
        {
            _logger.LogInfo("Generate a Keto Shopping List");
            return new KetoShoppingList();
        }
    }
}
