
namespace Visitor;
public class Home : Place
{
    public override void Visit(Visitor visitor)
    {
        visitor.VisitHome(this);
    }
}