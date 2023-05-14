namespace Strategy;

public class Log : Strategy
{
    public override void Do(int n)
    {
        Console.WriteLine("Logging number:");
        Next(n);
    }
}
