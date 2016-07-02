using System;

namespace DesignPatterns.Behavioral.NullObject
{
    class NullObject : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Null object pattern--\n");

            IBeer beer = new FullBeer();
            beer.Drink();

            beer = new EmptyBeer();
            beer.Drink();

            Console.WriteLine();
        }
    }


}
