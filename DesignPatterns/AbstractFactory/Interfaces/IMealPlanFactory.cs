namespace AbstractFactory.Interfaces
{
    public interface IMealPlanFactory
    {
        IMenu GenerateLunchMenu();
        IMenu GenerateDessertMenu();
        IShoppingList GenerateShoppingList();
    }
}
