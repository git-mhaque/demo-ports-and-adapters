using OrderApp.Core;

namespace OrderApp.Web
{
    public class Controller
    {
        private readonly IOrderService _service;
        private readonly ILogger _logger;

        public Controller(IOrderService service, ILogger logger)
        {
            _service = service;
            _logger = logger;
        }

        public bool SubmitOrder(OrderDto order)
        {
            _logger.LogMessage($"[Web] Submitting order # {order.OrderId} of {order.Amount} AUD");
            return _service.ProcessOrder(order);
        }
    }
}