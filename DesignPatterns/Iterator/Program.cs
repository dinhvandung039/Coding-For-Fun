/// Iterator is a behavioral pattern that allows sequential traversal through a complex data structure without its internal details
/// 
using Iterator;

var list = new LinkedListIterator<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);
list.Add(7);
Console.WriteLine(list);

Console.WriteLine(list.Get(3));