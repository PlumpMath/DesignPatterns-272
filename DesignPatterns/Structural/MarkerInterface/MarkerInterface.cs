using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.MarkerInterface
{
    // Using interfaces even though attributes are more suited for empty interfaces.
    class MarkerInterface : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Marker interface pattern--\n");

            var markable = new Markable();
            var nonMarkable = new object();

            var itemsToProcess = new List<object>
            {
                markable,
                nonMarkable
            };

            Process(itemsToProcess);

            Console.WriteLine();
        }

        private static void Process(List<object> items)
        {
            foreach (var item in items)
            {
                var markable = item as IMarker;

                var text = markable == null ? "non-markable" : "markable";
                Console.WriteLine(text);
            }
        }
    }
}
