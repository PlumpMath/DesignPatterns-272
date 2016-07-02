namespace DesignPatterns.Creational.AbstractFactory
{
    class OSXFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new OSXButton();
        }
    }
}
