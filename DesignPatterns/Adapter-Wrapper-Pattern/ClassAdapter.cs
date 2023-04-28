using Adapter_Wrapper_Pattern.BussinessLogic;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Adapter_Wrapper_Pattern
{
    // adapter
    public class ClassAdapter : SendGridClient, IUserNotificationService
    {
        private readonly SendGridClientOptions _options;

        // adaptee
        public ClassAdapter(SendGridClientOptions options) : base(options)
        {
            _options = options;
        }

        public Task NotifyUsers(string userId, string message)
        {
            return SendEmailAsync(new SendGridMessage());
        }
    }
}
// inheritance structure
// composition flexiblility