using OrderApp.Core;

namespace OrderApp.Infra.Database.Sql
{
    public class SqlOrderRepository : IOrderRepository
    {
        private readonly ILogger _logger;

        public SqlOrderRepository(ILogger logger)
        {
            _logger = logger;
        }

        public bool SaveOrder(OrderDto order)
        {
            _logger.LogMessage($"[Infra][Database SQL] Saving order # {order.OrderId} of {order.Amount} AUD");
            return true;
        }
    }
}