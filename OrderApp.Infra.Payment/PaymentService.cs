using System;
using OrderApp.Core;

namespace OrderApp.Infra.Payment
{
    public class PaymentService : IOrderPaymentService
    {
        public bool ProcessPayment(OrderDto order)
        {
            Console.WriteLine($"[Infra][Payment] Processing payment for order # {order.OrderId} of {order.Amount} AUD");
            return true;
        }
    }
}