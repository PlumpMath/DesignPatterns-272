using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Flyweight
{
    class Menu
    {
        public List<MenuItem> MenuItems { get; private set; }

        public Menu()
        {
            MenuItems = new List<MenuItem>
            {
                new MenuItem("Pig trotters from the Jura", 140),
                new MenuItem("Bresse Chicken", 240),
                new MenuItem("Shellfish from the Saint-Brieuc Bay", 75),
                new MenuItem("Viroflay Black Truffle salad", 155),
                new MenuItem("Landes Duck Foie Gras", 70),
                new MenuItem("Scallops Label Rouge from the Opal Coast", 70),
                new MenuItem("Blanch d'Ancelin Oysters", 140),
            };
        }

        public IEnumerable<MenuItem> GetItems(IEnumerable<string> items)
        {
            // we return only the references to the menu items, not newly 
            // created instances. 
            var list = new List<MenuItem>();

            foreach (var item in items)
            {
                list.Add(MenuItems.First(menuItem => menuItem.Name.Equals(item)));
            }

            return list;
        }
    }
}
