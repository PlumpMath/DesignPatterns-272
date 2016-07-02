using System;

namespace DesignPatterns.Creational.Singleton
{
    class Singleton : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Singleton pattern--\n");

            var universe = Universe.GetInstance();
            universe.BangLikeReallyBig();

            Console.WriteLine();
        }
    }
}
