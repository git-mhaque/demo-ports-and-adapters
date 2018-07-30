namespace OrderApp.Core
{
    public interface IOrderService
    {
        bool ProcessOrder(OrderDto order);
    }
}