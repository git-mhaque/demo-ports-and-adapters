using OrderApp.Core;

namespace OrderApp.Infra.Notification
{
    public class NotificationService : IOrderNotificationService
    {
        private readonly ILogger _logger;

        public NotificationService(ILogger logger)
        {
            _logger = logger;
        }

        public bool ProcessNotification(OrderDto order)
        {
            _logger.LogMessage($"[Infra][Notification] Sending notification for order # {order.OrderId} of {order.Amount} AUD");
            return true;
        }
    }
}