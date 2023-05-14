namespace Strategy
{
    public class Add : Strategy
    {
        int _num;
        public Add(int num) => _num = num;

        public override void Do(int n)
        {
            Console.WriteLine($"Adding {_num} to {n}");
            int result = n += _num;
            Console.WriteLine($"Result: {result}");
            Next(result);
        }
    }
}
