using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Windows paint");
        }
    }
}
