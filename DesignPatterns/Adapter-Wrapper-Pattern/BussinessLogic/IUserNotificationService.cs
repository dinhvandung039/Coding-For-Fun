namespace Adapter_Wrapper_Pattern.BussinessLogic
{
    public interface IUserNotificationService
    {
        Task NotifyUsers(string userId, string message);
    }
}
