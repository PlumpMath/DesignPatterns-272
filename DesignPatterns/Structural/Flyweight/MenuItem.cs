namespace DesignPatterns.Structural.Flyweight
{
    // This will be flyweight. We will only construct it
    // in the Menu class, and every order will just use a 
    // reference
    class MenuItem
    {
        public int Price { get; private set; }
        public string Name { get; private set; }

        public MenuItem(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
