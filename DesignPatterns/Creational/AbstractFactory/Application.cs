namespace DesignPatterns.Creational.AbstractFactory
{
    class Application
    {
        private readonly IButton _button;

        // This is how the abstract factory would be used, but isn't related to the pattern
        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
        }

        public void Run()
        {
            _button.Paint();
        }
    }
}
