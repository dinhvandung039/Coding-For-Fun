// Would try to avoid helper as much as possible => probably doding some kind of valid design pattern



// real world-example
// List is abstract, string, int are implementation
List<string> strings = new List<string>();
ICollection<string> names = new List<string>();
IEnumerable<string> values = new List<string>();

List<int> numbers = new List<int>();
ICollection<int> numbers2 = new List<int>();
IEnumerable<int> numbers3 = new List<int>();
