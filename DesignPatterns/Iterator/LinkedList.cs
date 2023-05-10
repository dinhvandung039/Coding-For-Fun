namespace Iterator;

public class LinkedListIterator<T>
{
    public Node _noded { get; set; }
    public class Node
    {
        public Node Next { get; set; }
        public T Value { get; set; }

        public void Append(T value)
        {
            if (Next == null)
            {
                Next = new Node { Value = value };
            }

            Next.Append(value);
        }

        public T Get(int i) => i == 0 ? Value : Next.Get(--i);
    }

    public void Add(T value)
    {
        if (_noded == null)
        {
            _noded = new Node { Value = value };
            return;
        }

        _noded.Append(value);
    }

    public T Get(int i) => _noded.Get(i);
}
