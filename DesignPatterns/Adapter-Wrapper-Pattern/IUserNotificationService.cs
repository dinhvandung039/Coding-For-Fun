namespace Adapter_Wrapper_Pattern
{
    public interface IUserNotificationService
    {
        Task NotifyUsers(string userId, string message);
    }
}
