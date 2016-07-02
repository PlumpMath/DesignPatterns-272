using System;

namespace DesignPatterns.Creational.LazyInitialization
{
    // C# has a Lazy method. If doing this in a real programming environment, 
    // use Lazy<>.
    class LazyInitialization : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Lazy initialization pattern--\n");

            var banana = new Banana();
            Console.WriteLine("Banana has been constructed.");
            Console.WriteLine("Banana is peeled (i.e. instantiated)? " + banana.IsLoaded());

            banana.Consume();
            Console.WriteLine("Banana is peeled (i.e. instantiated)? " + banana.IsLoaded());

            Console.WriteLine();
        }
    }
}
