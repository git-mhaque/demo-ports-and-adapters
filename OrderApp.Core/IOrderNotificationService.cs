namespace OrderApp.Core
{
    public interface IOrderNotificationService
    {
        bool ProcessNotification(OrderDto order);
    }
}