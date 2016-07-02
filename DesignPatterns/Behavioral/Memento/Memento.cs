using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Memento
{
    // This example is a little more complicated than the classic Memento as it 
    // remembers all the previous states and not just a single previous state
    class Memento : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Memento pattern--\n");

            var countries = new List<string>
            {
                "UK",
                "France"
            };
            var empire = new Empire(countries);

            Console.WriteLine("State1: ");
            empire.Output();

            empire.Conquer("Germany");
            Console.WriteLine("State2: ");
            empire.Output();

            empire.Conquer("Spain");
            Console.WriteLine("State4: ");
            empire.Output();

            empire.Conquer("Italy");
            Console.WriteLine("State5: ");
            empire.Output();

            empire.Surrender();
            Console.WriteLine("State6: ");
            empire.Output();

            empire.Surrender();
            Console.WriteLine("State7: ");
            empire.Output();

            empire.Surrender();
            Console.WriteLine("State8: ");
            empire.Output();

            empire.Surrender();
            Console.WriteLine("State9: ");
            empire.Output();

            Console.WriteLine();
        }
    }
}
