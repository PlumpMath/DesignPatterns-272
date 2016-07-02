using System;

namespace DesignPatterns.Behavioral.State
{
    class State : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--State pattern--\n");

            var life = new Life();

            life.Live();
            life.Live();
            life.Live();
            life.Live();
            life.Live();
            life.Live();
            life.Live();
            life.Live();
            life.Live();
            life.Live();

            Console.WriteLine();
        }
    }
}
