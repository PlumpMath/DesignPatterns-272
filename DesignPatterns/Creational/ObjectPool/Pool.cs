using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.ObjectPool
{
    // A pool that can only have 5 swimmers in it at one time.
    // In a real world scenario, the Swimmer class would contain 
    // a heavy world load which a caller can assign.
    class Pool
    {
        private IList<Swimmer> _availableSwimmers;
        private IList<Swimmer> _swimmingSwimmers;

        public Pool()
        {
            _availableSwimmers = new List<Swimmer>
            {
                new Swimmer(),
                new Swimmer(),
                new Swimmer(),
                new Swimmer(),
                new Swimmer()
            };
            _swimmingSwimmers = new List<Swimmer>();
        }

        public bool CanGetSwimmer()
        {
            return _availableSwimmers.Any();
        }

        public bool TryGetSwimmer(out Swimmer swimmer)
        {
            swimmer = null;

            if (!_availableSwimmers.Any())
                return false;

            var availableSwimmer = _availableSwimmers.First();

            _availableSwimmers.Remove(availableSwimmer);
            _swimmingSwimmers.Add(availableSwimmer);

            swimmer = availableSwimmer;

            return true;
        }

        public void StopSwimmer(Swimmer swimmer)
        {
            if (!_swimmingSwimmers.Contains(swimmer))
                return;

            // clear data
            swimmer.Person = null;

            // rearrange used/available lists
            _swimmingSwimmers.Remove(swimmer);
            _availableSwimmers.Add(swimmer);
        }
    }
}
