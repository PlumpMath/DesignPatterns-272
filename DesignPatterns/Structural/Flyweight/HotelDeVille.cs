using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    class HotelDeVille // In Crissier, CH
    {
        public Menu Menu;

        public HotelDeVille()
        {
            Menu = new Menu();
        }

        public Order PlaceOrder(IEnumerable<string> menuItems)
        {
            var items = Menu.GetItems(menuItems);
            return new Order(items);
        }
    }
}
