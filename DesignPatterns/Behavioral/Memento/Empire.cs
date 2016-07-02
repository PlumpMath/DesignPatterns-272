using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Memento
{
    // This empire can only surrender countries in the order 
    // in which it conquered them
    class Empire
    {
        private readonly Stack<Empire> _previousStates;
        
        public Empire(List<string> countries)
        {
            Countries = countries;
            _previousStates = new Stack<Empire>();
        }

        public List<string> Countries { get; private set; }

        public void Conquer(string country)
        {
            _previousStates.Push(DeepCopy());
            Countries.Add(country);
        }

        public void Surrender()
        {
            if (_previousStates.Count == 0)
                return;

            var previousState = _previousStates.Pop();

            Countries = new List<string>(previousState.Countries);
        }

        public void Output()
        {
            var message = "Countries conquered: ";
            foreach (var country in Countries)
                message += country + " ";

            Console.WriteLine(message);
        }

        private Empire DeepCopy()
        {
            return new Empire(new List<string>(Countries));
        }
    }
}
