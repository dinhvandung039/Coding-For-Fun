
/// Template Method allows you to defines a skeleton of an algorithm in a base class and let subclass  
/// override the steps without changing the overall algorithm's structure
/// Complexity: 1
/// Popularity: 2
/// 



public class Variation3 : Process
{
    protected override void FactoryMethod() => Console.WriteLine("FactoryMethod Variation3");
}
