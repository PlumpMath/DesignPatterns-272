using System;

namespace DesignPatterns.Structural.Composite
{
    class PearTree : IHarvestable
    {
        public void Harvest()
        {
            Console.WriteLine("Pear harvested");
        }
    }
}
