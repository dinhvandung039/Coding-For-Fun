/// Visitor lets you separate algorithms from the objects on which they operate
/// Complexity: 3
/// Popularity: 1
///  <summary>
/// Visitor lets you separate algorithms from the objects on which they operate
/// </summary>
/// 

namespace Visitor;

public abstract class Visitor
{
    public abstract void VisitPark(Park park);
    public abstract void VisitHome(Home park);
}