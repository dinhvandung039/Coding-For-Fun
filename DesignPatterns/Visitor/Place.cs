/// Visitor lets you separate algorithms from the objects on which they operate
/// Complexity: 3
/// Popularity: 1
/// 

namespace Visitor;
public abstract class Place
{
    public abstract void Visit(Visitor visitor);
}
