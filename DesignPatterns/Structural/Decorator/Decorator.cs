using System;

namespace DesignPatterns.Structural.Decorator
{
    class Decorator : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Decorator pattern--\n");

            // basic 
            var basicLoMein = new LoMein();
            PrintNoodleDetails(basicLoMein);

            // decorator
            var wonton = new Wonton();
            var mushroom = new MushroomNoodles(wonton);

            // decorate the decorators
            var mushroom2 = new MushroomNoodles(mushroom);
            var onion = new OnionNoodles(mushroom2);
            var babycorn = new BabyCornNoodles(onion);
            PrintNoodleDetails(babycorn);

            Console.WriteLine();
        }

        private static void PrintNoodleDetails(INoodles noodles)
        {
            Console.WriteLine("Noodles (" + noodles.Price() + "p) with:");
            foreach (var ingredient in noodles.Ingredients)
                Console.WriteLine("  " + ingredient);
        }
    }
}
