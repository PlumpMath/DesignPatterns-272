using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    class Orchard : IHarvestable
    {
        private readonly IList<IHarvestable> _harvestables;

        public Orchard()
        {
            _harvestables = new List<IHarvestable>();
        }

        public void Add(IHarvestable harvestable)
        {
            _harvestables.Add(harvestable);
        }

        public void Harvest()
        {
            foreach (var harvestable in _harvestables)
            {
                harvestable.Harvest();
            }
        }
    }
}
