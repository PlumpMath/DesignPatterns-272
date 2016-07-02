using System;

namespace DesignPatterns.Structural.Composite
{
    class AppleTree : IHarvestable
    {
        public void Harvest()
        {
            Console.WriteLine("Apple harvested");
        }
    }
}
