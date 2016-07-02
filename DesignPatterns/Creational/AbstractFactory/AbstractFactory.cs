using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    class AbstractFactory : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Abstract factory pattern--\n");

            // Construct two different application by passing in a factory
            // which creates a button. The application class is therefore 
            // os-agnostic. The construction of the object is delayed until
            // the application needs it (instead of just passing it in here).

            var windowsApplication = new Application(new WinFactory());
            windowsApplication.Run();

            var osxApplication = new Application(new OSXFactory());
            osxApplication.Run();

            Console.WriteLine();
        }
    }
}
