using Autofac;
using OrderApp.Core;
using OrderApp.Infra.Database.Sql;
using OrderApp.Infra.Notification;
using OrderApp.Infra.Payment;
using OrderApp.Infra.Shipping;
using OrderApp.Web;

namespace OrderApp
{
    public class Program
    {
        public static void Main()
        {
            var controller = GetController();

            controller.SubmitOrder(new OrderDto
            {
                OrderId = 712,
                Amount = 5000
            });
        }
        
        private static Controller GetController()
        {
            var container = BuildContainer();
            Controller controller = null; 

            using (var scope = container.BeginLifetimeScope())
            {
                controller = scope.Resolve<Controller>();
            }

            return controller;
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<OrderService>().As<IOrderService>();
            builder.RegisterType<PaymentService>().As<IOrderPaymentService>();
            builder.RegisterType<ShippingService>().As<IOrderShippingService>();
            builder.RegisterType<NotificationService>().As<IOrderNotificationService>();
            builder.RegisterType<Controller>();

            return builder.Build();
        }
    }
}