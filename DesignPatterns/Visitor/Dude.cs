namespace Visitor;

public class Dude : Visitor
{
    public override void VisitHome(Home park)
    {
        Console.WriteLine("Playing video game");
    }

    public override void VisitPark(Park park)
    {
        Console.WriteLine("Smoke weed");
    }
}
