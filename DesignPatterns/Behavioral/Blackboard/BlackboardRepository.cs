using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Blackboard
{
    class BlackboardRepository
    {
        public BlackboardRepository(List<ItemOfInterest> items)
        {
            Items = items;
        }

        public List<ItemOfInterest> Items { get; private set; }
    }
}
