using OrderApp.Core;

namespace OrderApp.Infra.Database.NoSql
{
    public class NoSqlOrderRepository : IOrderRepository
    {
        private readonly ILogger _logger;

        public NoSqlOrderRepository(ILogger logger)
        {
            _logger = logger;
        }

        public bool SaveOrder(OrderDto order)
        {
            _logger.LogMessage($"[Infra][Database NoSQL] Saving order # {order.OrderId} of {order.Amount} AUD");
            return true;
        }
    }
}