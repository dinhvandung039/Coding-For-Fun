using Strategy;
/// Strategy turns set of behaviors into objects and makes interchangeable inside original context objects.
/// Complexity: 1
/// Popularity: 3
/// Composite + strategy
/// 

var chain1 = new Log().Append(new Transaction()).Append(new Add(5));
chain1.Do(10);

Console.WriteLine("-------------------");

var chain2 = new Log().Append(new Add(10)).Append(new Transaction());
chain2.Do(10);