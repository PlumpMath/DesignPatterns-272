using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    class OSXButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("OSX paint");
        }
    }
}
