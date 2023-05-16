namespace Visitor;

public class Robber : Visitor
{
    public override void VisitHome(Home park)
    {
        Console.WriteLine("Steal from stock");
    }

    public override void VisitPark(Park park)
    {
        Console.WriteLine("Steal a dog");
    }
}
