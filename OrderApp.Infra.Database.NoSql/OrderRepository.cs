using System;
using OrderApp.Core;

namespace OrderApp.Infra.Database.NoSql
{
    public class OrderRepository : IOrderRepository
    {
        public bool SaveOrder(OrderDto order)
        {
            Console.WriteLine($"[Infra][Database NoSQL] Saving order # {order.OrderId} of {order.Amount} AUD");
            return true;
        }
    }
}