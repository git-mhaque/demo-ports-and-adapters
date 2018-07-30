namespace OrderApp.Core
{
    public interface IOrderShippingService
    {
        bool ProcessShipping(OrderDto order);
    }
}