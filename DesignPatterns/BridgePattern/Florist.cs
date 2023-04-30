// Would try to avoid helper as much as possible => probably doding some kind of valid design pattern

using BridgePattern.Abstractions;

public class Florist : FarmersMarketVendor
{
    private readonly IProcessesPayments _paymentProcessor;

    public Florist(IProcessesPayments paymentProcessor) : base(paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public override string ProcessCustomerPayment(decimal payment, string vendorName)
    {
        Console.WriteLine($"Florist: {vendorName} is processing " +
                          $"a ${payment} payment for a vial of lavender oil");
        return _paymentProcessor.HandlePayment(payment);
    }
}