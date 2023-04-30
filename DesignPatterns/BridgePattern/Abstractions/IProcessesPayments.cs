namespace BridgePattern.Abstractions;

public interface IProcessesPayments
{
    string HandlePayment(decimal paymentAmount);
}
