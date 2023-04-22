using BuilderPattern.Builders;
using BuilderPattern.Builders.Implementations;
using BuilderPattern.Builders.Models;
using RealisticDependencies.Implementations;

var customOrder = new FluentPurchaseOrderBuilder();

var items = new List<LineItem>()
{
    new("cups", 100, 1.0m),
    new("napkins", 250, 0.3m),
};

var supplier = new Supplier("Jenkins", "asdasd@gmail.com", "CI Jenkins");

customOrder.WithId("1").AtAddress("asda").ForCompany("Productive").FromSupplier(supplier)
    .RequestDate(DateTime.Now.AddDays(-2))
    .ForItems(items);

var logger = new ConsoleLogger();
var database = new Database("ConnectionString", logger);

// concrete 
var poProcessor = new PurchaseOrderProcessor(logger, database);

await poProcessor.SavePurchaseOrderToDatabase(customOrder);
poProcessor.PrintPurchaseOrder(customOrder);



