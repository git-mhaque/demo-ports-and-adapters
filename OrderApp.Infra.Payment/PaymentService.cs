using OrderApp.Core;

namespace OrderApp.Infra.Payment
{
    public class PaymentService : IOrderPaymentService
    {
        private readonly ILogger _logger;

        public PaymentService(ILogger logger)
        {
            _logger = logger;
        }

        public bool ProcessPayment(OrderDto order)
        {
            _logger.LogMessage($"[Infra][Payment] Processing payment for order # {order.OrderId} of {order.Amount} AUD");
            return true;
        }
    }
}