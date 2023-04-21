using BuilderPattern.Builders.Interfaces;
using BuilderPattern.Builders.Models;

namespace BuilderPattern.Builders.Implementations
{
    public class FluentPurchaseOrderBuilder : IFluentPurchaseOrderBuilder
    {
        private string _id;
        private DateTime _requestDate;
        private string _companyName;
        private string _companyAddress;
        private Supplier _supplier;
        private IEnumerable<LineItem> _lineItems;

        public IFluentPurchaseOrderBuilder WithId(string id)
        {
            _id = id;
            return this;
        }

        public IFluentPurchaseOrderBuilder ForCompany(string companyName)
        {
            _companyAddress = companyName;
            return this;
        }

        public IFluentPurchaseOrderBuilder RequestDate(DateTime date)
        {
            _requestDate = date;
            return this;
        }

        public IFluentPurchaseOrderBuilder AtAddress(string address)
        {
            _companyAddress = address;
            return this;
        }

        public IFluentPurchaseOrderBuilder ForItems(List<LineItem> lineItems)
        {
            _lineItems = lineItems;
            return this;
        }

        public IFluentPurchaseOrderBuilder FromSupplier(Supplier supplier)
        {
            _supplier = supplier;
            return this;
        }

        public PurchaseOrder BuildPurchaseOrder()
        {
            return new()
            {
                Id = _id,
                RequestDate = _requestDate,
                CreatedOn = DateTime.UtcNow,
                CompanyName = _companyName,
                CompanyAddress = _companyAddress,
                Supplier = _supplier,
                LineItems = _lineItems
            };
        }

        public static implicit operator PurchaseOrder(FluentPurchaseOrderBuilder builder)
        {
            return builder.BuildPurchaseOrder();
        }
    }
}
