using System;
using OrderApp.Core;

namespace OrderApp.Web
{
    public class Controller
    {
        private readonly IOrderService _service;

        public Controller(IOrderService service)
        {
            _service = service;
        }

        public bool SubmitOrder(OrderDto order)
        {
            Console.WriteLine($"[Web] Submitting order # {order.OrderId} of {order.Amount} AUD");
            return _service.ProcessOrder(order);
        }
    }
}