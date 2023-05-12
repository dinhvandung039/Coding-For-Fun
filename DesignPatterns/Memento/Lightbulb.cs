namespace Memento
{
    public class Lightbulb
    {
        public bool IsPowerOn = false;
        public void TogglePower()
        {
            if (!IsPowerOn)
            {
                IsPowerOn = true;
                Console.WriteLine("Power On");
            }
            else
            {
                IsPowerOn = false;
                Console.WriteLine("Power Off");
            }
        }

        public void SetLightColor(int lightColor)
        {
            PrintLightColor(lightColor);
        }

        public void SetRandomLightColar(int randomNumber)
        {
            PrintLightColor(randomNumber);
        }

        private void PrintLightColor(int randomNumber)
        {
            if (randomNumber == 1) { Console.WriteLine("Red"); }
            else if (randomNumber == 2) { Console.WriteLine("Blue"); }
            else if (randomNumber == 3) { Console.WriteLine("Yellow"); }
            else if (randomNumber == 4) { Console.WriteLine("Orange"); }
            else if (randomNumber == 5) { Console.WriteLine("Black"); }
            else { Console.WriteLine("Green"); }
        }
    }
}