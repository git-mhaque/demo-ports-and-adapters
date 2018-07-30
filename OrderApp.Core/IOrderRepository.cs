namespace OrderApp.Core
{
    public interface IOrderRepository
    {
        bool SaveOrder(OrderDto order);
    }
}