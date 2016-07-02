using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    class Flyweight : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Flyweight pattern--\n");

            var hotelDeVille = new HotelDeVille();
            var menu = hotelDeVille.Menu;

            var items = new List<string>
            {
                menu.MenuItems[0].Name,
                menu.MenuItems[2].Name,
                menu.MenuItems[4].Name,
                menu.MenuItems[5].Name,
            };

            var order = hotelDeVille.PlaceOrder(items);

            Console.WriteLine("Order: ");
            Console.WriteLine("Total cost: " + order.Price + " CHF");
            Console.WriteLine("Items: ");
            foreach (var item in order.MenuItems)
            {
                Console.WriteLine("  " + item.Name);
            }

            Console.WriteLine();
        }
    }
}
