using Ocp.Order;

namespace Ocp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Order.Order order1 = new Order.Order(Guid.NewGuid(), "T-Shirt", 200);
            order1.setDiscount(new FixedDiscount(10));
            Console.WriteLine(order1.getAmount());

            Order.Order order2 = new Order.Order(Guid.NewGuid(), "T-Shirt", 200);
            order2.setDiscount(new PercentageDiscount(10));
            Console.WriteLine(order2.getAmount());
        }
    }
}