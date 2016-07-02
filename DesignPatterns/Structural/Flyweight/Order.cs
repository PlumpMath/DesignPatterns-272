using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    class Order
    {
        public int Price { get; private set; }
        public IList<MenuItem> MenuItems { get; private set; }

        public Order(IEnumerable<MenuItem> menuItems)
        {
            MenuItems = new List<MenuItem>();
            Price = 0;

            foreach (var item in menuItems)
            {
                Price += item.Price;
                MenuItems.Add(item);
            }
        }
    }
}
