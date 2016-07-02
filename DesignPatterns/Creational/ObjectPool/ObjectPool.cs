using System;

namespace DesignPatterns.Creational.ObjectPool
{
    class ObjectPool : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Object pool pattern--\n");

            var pool = new Pool();

            Swimmer swimmer1;
            var retrievedSwimmer1 = pool.TryGetSwimmer(out swimmer1);
            Console.WriteLine("Retrieved swimmer 1: " + retrievedSwimmer1);
            swimmer1.Person = new Person();

            Swimmer swimmer2;
            var retrievedSwimmer2 = pool.TryGetSwimmer(out swimmer2);
            Console.WriteLine("Retrieved swimmer 2: " + retrievedSwimmer2);
            swimmer2.Person = new Person();

            Swimmer swimmer3;
            var retrievedSwimmer3 = pool.TryGetSwimmer(out swimmer3);
            Console.WriteLine("Retrieved swimmer 3: " + retrievedSwimmer3);
            swimmer3.Person = new Person();

            Swimmer swimmer4;
            var retrievedSwimmer4 = pool.TryGetSwimmer(out swimmer4);
            Console.WriteLine("Retrieved swimmer 4: " + retrievedSwimmer4);
            swimmer4.Person = new Person();

            Swimmer swimmer5;
            var retrievedSwimmer5 = pool.TryGetSwimmer(out swimmer5);
            Console.WriteLine("Retrieved swimmer 5: " + retrievedSwimmer5);
            swimmer5.Person = new Person();

            // No more swimmers!
            Swimmer swimmer6;
            var retrievedSwimmer6 = pool.TryGetSwimmer(out swimmer6);
            Console.WriteLine("Retrieved swimmer 6: " + retrievedSwimmer6);

            // Stop swimmer.
            pool.StopSwimmer(swimmer1);

            // Get swimmer 6.
            retrievedSwimmer6 = pool.TryGetSwimmer(out swimmer6);
            Console.WriteLine("Retrieved swimmer 6: " + retrievedSwimmer6);

            Console.WriteLine();
        }
    }
}
