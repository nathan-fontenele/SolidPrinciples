using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Srp.Order
{
    internal class OrderProcessor
    {
        private readonly InventoryChecker _inventoryChecker;
        private readonly OrderCalculator _orderCalculator;
        private readonly PaymentProcessor _paymentProcessor;


        public OrderProcessor(InventoryChecker inventoryChecker, OrderCalculator orderCalculator, PaymentProcessor paymentProcessor)

        {
            _inventoryChecker = inventoryChecker;
            _orderCalculator = orderCalculator;
            _paymentProcessor = paymentProcessor;
        }

        public void processorOrder(Order order) {
            _inventoryChecker.CheckInventory(order);
            _orderCalculator.CalculateTotalOrder(order);
            _paymentProcessor.Process(order);
        }
    }
}
