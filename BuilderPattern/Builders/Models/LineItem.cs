namespace BuilderPattern.Builders.Models
{
    public class LineItem
    {
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal UnitCost { get; set; }
        public LineItem(string name, int qty, decimal unitCost) => (Name, Qty, UnitCost) = (name, qty, unitCost);
    }
}
