using System;

namespace DesignPatterns.Creational.RAII
{
    class RAII : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--RAII pattern--\n");

            var human = new Human();
            Console.WriteLine("Human created. Has breath: " + human.Breath.HasBreath);

            human.Dispose();
            Console.WriteLine("Human destroyed. Has breath: " + human.Breath.HasBreath);
           
            Console.WriteLine();
        }
    }
}
