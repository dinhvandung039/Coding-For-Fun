namespace BuilderPattern.Builders.Models
{
    public class PurchaseOrder
    {
        public string Id { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public decimal TotalCost { get; set; }
        public Supplier Supplier { get; set; }
        public IEnumerable<LineItem> LineItems { get; set; }
    }
}
