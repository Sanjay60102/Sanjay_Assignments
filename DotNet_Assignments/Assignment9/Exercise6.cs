using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Exercise6
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

            List<Item> items = new List<Item>
        {
            new Item("Watch", 100),
            new Item("Shoes", 200),
            new Item("Tv", 150),
            new Item("Phone", 250),
            new Item("Laptop", 300)
        };

            var query = from order in orders
                        join item in items on order.ItemName equals item.ItemName
                        let totalPrice = order.Quantity * item.Price
                        orderby order.OrderDate descending
                        group new { order.OrderId, order.ItemName, order.OrderDate, TotalPrice = totalPrice } by new { order.OrderDate.Year, order.OrderDate.Month } into g
                        orderby g.Key.Year descending, g.Key.Month descending
                        select new
                        {
                            Year = g.Key.Year,
                            Month = g.Key.Month,
                            Orders = g
                        };

            Console.WriteLine("Orders grouped by month and sorted by date:");
            foreach (var group in query)
            {
                Console.WriteLine($"Year: {group.Year}, Month: {group.Month}");
                foreach (var order in group.Orders)
                {
                    Console.WriteLine($"Order ID: {order.OrderId}, Item Name: {order.ItemName}, Order Date: {order.OrderDate.ToShortDateString()}, Total Price: {order.TotalPrice:C}");
                }
            }
        }
    }
}
