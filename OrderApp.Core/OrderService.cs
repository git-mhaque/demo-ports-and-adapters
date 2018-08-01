namespace OrderApp.Core
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderPaymentService _paymentService;
        private readonly IOrderShippingService _shippingService;
        private readonly IOrderNotificationService _notificationService;
        private readonly ILogger _logger;

        public OrderService(
                IOrderRepository orderRepository, 
                IOrderPaymentService paymentService,
                IOrderShippingService shippingService,
                IOrderNotificationService notificationService,
                ILogger logger)
        {
            _orderRepository = orderRepository;
            _paymentService = paymentService;
            _shippingService = shippingService;
            _notificationService = notificationService;
            _logger = logger;
        }

        public bool ProcessOrder(OrderDto order)
        {
            _logger.LogMessage($"[Core] Processing order # {order.OrderId} of {order.Amount} AUD");
            
            order.Amount *= 1.10;

            _orderRepository.SaveOrder(order);
            _paymentService.ProcessPayment(order);
            _shippingService.ProcessShipping(order);
            _notificationService.ProcessNotification(order);

            return true;
        }
    }
}