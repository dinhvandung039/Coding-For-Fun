namespace Adapter_Wrapper_Pattern
{
    public class BitcoinEvent
    {
        private readonly IUserNotificationService userNF;

        public BitcoinEvent(IUserNotificationService userNF)
        {
            this.userNF = userNF;
        }

        public Task Execute()
        {
            // other work here
            return userNF.NotifyUsers("", "");
        }
    }
}
