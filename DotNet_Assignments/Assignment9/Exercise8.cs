using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Exercise8
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

            // Check if all quantities are greater than 0
            bool allQuantitiesGreaterThanZero = orders.All(o => o.Quantity > 0);
            Console.WriteLine($"All quantities > 0: {allQuantitiesGreaterThanZero}");

            // Get the name of the item ordered in the largest quantity in a single order using query syntax
            var maxQuantityOrder = (from order in orders
                                    orderby order.Quantity descending
                                    select order).FirstOrDefault();
            string itemNameWithMaxQuantity = maxQuantityOrder != null ? maxQuantityOrder.ItemName : "No orders";
            Console.WriteLine($"Item ordered in largest quantity: {itemNameWithMaxQuantity}");

            // Find if there are any orders placed before January of this year using query syntax
            DateTime januaryFirstThisYear = new DateTime(DateTime.Now.Year, 1, 1);
            bool anyOrdersBeforeJanuary = (from order in orders
                                           where order.OrderDate < januaryFirstThisYear
                                           select order).Any();
            Console.WriteLine($"Any orders placed before January of this year: {anyOrdersBeforeJanuary}");
        }
    }
}
