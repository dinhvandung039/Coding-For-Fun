using AbstractFactory.Interfaces;
using RealisticDependencies.Interfaces;

namespace AbstractFactory.Implementations
{
    public class VegetarianMealPlanFactory : IMealPlanFactory
    {
        private readonly IApplicationLogger _logger;

        public VegetarianMealPlanFactory(IApplicationLogger logger)
        {
            _logger = logger;
        }

        public IMenu GenerateDessertMenu()
        {
            throw new NotImplementedException();
        }

        public IMenu GenerateLunchMenu()
        {
            throw new NotImplementedException();
        }

        public IShoppingList GenerateShoppingList()
        {
            throw new NotImplementedException();
        }
    }
}
