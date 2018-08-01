using OrderApp.Core;

namespace OrderApp.Infra.Shipping
{
    public class ShippingService : IOrderShippingService
    {
        private readonly ILogger _logger;

        public ShippingService(ILogger logger)
        {
            _logger = logger;
        }

        public bool ProcessShipping(OrderDto order)
        {
            _logger.LogMessage($"[Infra][Shipment] Processing shipment for order # {order.OrderId} of {order.Amount} AUD");
            return true;
        }
    }
}