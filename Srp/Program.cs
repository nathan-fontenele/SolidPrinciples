
using Srp.Order;


namespace Srp
{
    class Program
    {
        static void Main(string[] args)
        {
            Order.Order order = new Order.Order(Guid.NewGuid(), "pedido1");

            var inventoryChecker = new InventoryChecker();
            var orderCalculator = new OrderCalculator();
            var paymentProcessor = new PaymentProcessor();

            var orderProcessor = new OrderProcessor
                (
                    inventoryChecker,
                    orderCalculator,
                    paymentProcessor
                );


            orderProcessor.processorOrder(order);
        }

    }
}