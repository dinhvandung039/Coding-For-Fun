using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations
{
    public class KetoLunchMenu : IMenu
    {
        public void PrintDescription()
        {
            Console.WriteLine("The keto lunch menu");
        }

        public void PrintMenu()
        {
            Console.WriteLine("Print Keto Lunch Menu");
        }
    }
}