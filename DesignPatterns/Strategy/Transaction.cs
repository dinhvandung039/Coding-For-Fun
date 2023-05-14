namespace Strategy
{
    public class Transaction : Strategy
    {
        public override void Do(int n)
        {
            Console.WriteLine("Starting Transaction");
            Next(n);
            Console.WriteLine("Finishing Transaction");
        }
    }
}
