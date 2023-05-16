
namespace Visitor;
public class Park : Place
{
    public override void Visit(Visitor visitor)
    {
        visitor.VisitPark(this);
    }
}