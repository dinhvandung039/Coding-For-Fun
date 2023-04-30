// Would try to avoid helper as much as possible => probably doding some kind of valid design pattern

using BridgePattern.Abstractions;

public class CattleFarmer : FarmersMarketVendor
{
    private readonly IProcessesPayments _paymentProcessor;

    public CattleFarmer(IProcessesPayments paymentProcessor) : base(paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public override string ProcessCustomerPayment(decimal payment, string vendorName)
    {
        Console.WriteLine($"CattleFarmer: {vendorName} is processing " +
                          $"a ${payment} payment for grass-fed short ribs");
        return _paymentProcessor.HandlePayment(payment);
    }
}