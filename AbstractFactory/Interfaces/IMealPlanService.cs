namespace AbstractFactory.Interfaces
{
    public interface IMealPlanService
    {
        Task SendMealPlanToSubscriber(string subscribeEmail);
    }
}
