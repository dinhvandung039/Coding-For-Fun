using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations
{
    public class KetoShoppingList : IShoppingList
    {
        public List<string> MakeShoppingList()
        {
            return new()
            {
                "butter", "meat"
            };
        }
    }
}