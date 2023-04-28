using Adapter_Wrapper_Pattern.BussinessLogic;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Adapter_Wrapper_Pattern
{
    public class ObjectAdapter : IUserNotificationService
    {
        private readonly SendGridClient _client;

        public ObjectAdapter(SendGridClient client)
        {
            _client = client;
        }
        public Task NotifyUsers(string userId, string message)
        {
            return _client.SendEmailAsync(new SendGridMessage());
        }
    }
}

// Adapter - ObjectAdapter
// Adaptee - NotifyUsers