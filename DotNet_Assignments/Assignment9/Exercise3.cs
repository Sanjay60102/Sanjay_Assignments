using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Order
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }

        public Order(int orderId, string itemName, DateTime orderDate, int quantity)
        {
            OrderId = orderId;
            ItemName = itemName;
            OrderDate = orderDate;
            Quantity = quantity;
        }
    }
    internal class Exercise3
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
        {
            new Order(1, "Watch", new DateTime(2024, 7, 19), 10),
            new Order(2, "Shoes", new DateTime(2024, 7, 18), 5),
            new Order(3, "Tv", new DateTime(2024, 7, 19), 15),
            new Order(4, "Phone", new DateTime(2024, 7, 17), 20),
            new Order(5, "Laptop", new DateTime(2024, 7, 18), 25)
        };

            var sortedOrders = orders
                .OrderByDescending(o => o.OrderDate)
                .ThenByDescending(o => o.Quantity)
                .ToList();

            Console.WriteLine("Orders sorted by date and quantity:");
            foreach (var order in sortedOrders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}, Item Name: {order.ItemName}, Order Date: {order.OrderDate.ToShortDateString()}, Quantity: {order.Quantity}");
            }
        }

    }
}
