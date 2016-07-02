using System;

namespace DesignPatterns.Structural.Adapter
{
    class Adapter : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Adapter pattern--\n");

            var man = new Man();
            man.Live();

            var woman = new Woman();
            woman.Live();

            var hermaphrodite = new Hermaphrodite();
            hermaphrodite.Live();

            Console.WriteLine();
        }
    }
}
