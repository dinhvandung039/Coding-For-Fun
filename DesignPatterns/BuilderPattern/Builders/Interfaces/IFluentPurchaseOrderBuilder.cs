using BuilderPattern.Builders.Models;

namespace BuilderPattern.Builders.Interfaces
{
    public interface IFluentPurchaseOrderBuilder
    {
        IFluentPurchaseOrderBuilder WithId(string id);
        IFluentPurchaseOrderBuilder ForCompany(string companyName);
        IFluentPurchaseOrderBuilder AtAddress(string address);
        IFluentPurchaseOrderBuilder RequestDate(DateTime date);
        IFluentPurchaseOrderBuilder FromSupplier(Supplier supplier);
        IFluentPurchaseOrderBuilder ForItems(List<LineItem> lineItems);
        PurchaseOrder BuildPurchaseOrder();
    }
}
