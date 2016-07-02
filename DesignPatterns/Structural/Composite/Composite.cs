using System;

namespace DesignPatterns.Structural.Composite
{
    class Composite : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Composite pattern--\n");

            var appleTree = new AppleTree();
            var pearTree = new PearTree();
            var orchard = new Orchard();
            orchard.Add(new AppleTree());
            orchard.Add(new AppleTree());
            orchard.Add(new AppleTree());
            orchard.Add(new PearTree());

            Harvest(appleTree);
            Harvest(pearTree);
            Harvest(orchard);

            Console.WriteLine();
        }

        private static void Harvest(IHarvestable harvestable)
        {
            harvestable.Harvest();
        }
    }
}
