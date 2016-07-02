namespace DesignPatterns.Creational.AbstractFactory
{
    class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }
    }
}
