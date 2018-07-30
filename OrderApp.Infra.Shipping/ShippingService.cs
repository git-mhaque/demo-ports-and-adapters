using System;
using OrderApp.Core;

namespace OrderApp.Infra.Shipping
{
    public class ShippingService : IOrderShippingService
    {
        public bool ProcessShipping(OrderDto order)
        {
            Console.WriteLine($"[Infra][Shipment] Processing shipment for order # {order.OrderId} of {order.Amount} AUD");
            return true;
        }
    }
}