using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations
{
    public class KetoDessertMenu : IMenu
    {
        public void PrintDescription()
        {
            Console.WriteLine("The keto dessert menu");
        }

        public void PrintMenu()
        {
            Console.WriteLine("Print Keto Dessert Menu");
        }
    }
}
