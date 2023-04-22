namespace BuilderPattern.Builders.Models
{
    public class Supplier
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactName { get; set; }
        public Supplier(string name, string email, string contactName) => (Name, Email, ContactName) = (name, email, contactName);
    }
}
