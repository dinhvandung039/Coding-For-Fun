using AbstractFactory.Implementations;

namespace AbstractFactory.Interfaces
{
    public interface ISendEmail
    {
        Task SendMessage(EmailMessage message);
    }
}
