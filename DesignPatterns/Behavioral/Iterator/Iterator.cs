using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator
{
    // We could just iterate over a list but it's more fun 
    // to actually implement a class that can iterate
    class Iterator : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Iterator pattern--\n");

            var items = new List<Item>
            {
                new Item("item1"),
                new Item("item2"),
                new Item("item3"),
                new Item("item4"),
                new Item("item5"),
                new Item("item6"),
                new Item("item7"),
                new Item("item8"),
            };

            var iterable = new Iterable(items);

            while (!iterable.End())
            {
                Console.WriteLine(iterable.Next().Data);
            }

            Console.WriteLine();
        }
    }
}
