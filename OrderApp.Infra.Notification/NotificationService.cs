using System;
using OrderApp.Core;

namespace OrderApp.Infra.Notification
{
    public class NotificationService : IOrderNotificationService
    {
        public bool ProcessNotification(OrderDto order)
        {
            Console.WriteLine($"[Infra][Notification] Sending notification for order # {order.OrderId} of {order.Amount} AUD");
            return true;
        }
    }
}