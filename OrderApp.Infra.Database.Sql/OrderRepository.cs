using System;
using OrderApp.Core;

namespace OrderApp.Infra.Database.Sql
{
    public class OrderRepository : IOrderRepository
    {
        public bool SaveOrder(OrderDto order)
        {
            Console.WriteLine($"[Infra][Database SQL] Saving order # {order.OrderId} of {order.Amount} AUD");
            return true;
        }
    }
}