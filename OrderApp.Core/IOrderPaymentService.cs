namespace OrderApp.Core
{
    public interface IOrderPaymentService
    {
        bool ProcessPayment(OrderDto order);
    }
}