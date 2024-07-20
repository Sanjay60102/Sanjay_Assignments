using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Exercise4
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

            var groupedOrders = orders
                .OrderByDescending(o => o.OrderDate)
                .GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                .OrderByDescending(g => g.Key.Year)
                .ThenByDescending(g => g.Key.Month);

            Console.WriteLine("Orders grouped by month and sorted by date:");
            foreach (var group in groupedOrders)
            {
                Console.WriteLine($"Year: {group.Key.Year}, Month: {group.Key.Month}");
                foreach (var order in group)
                {
                    Console.WriteLine($"Order ID: {order.OrderId}, Item Name: {order.ItemName}, Order Date: {order.OrderDate.ToShortDateString()}, Quantity: {order.Quantity}");
                }
            }
        }
    }
}
