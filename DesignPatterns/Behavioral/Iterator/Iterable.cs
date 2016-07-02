using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator
{
    class Iterable 
    {
        private readonly List<Item> _dataStore;
        private int _position; 

        public Iterable(List<Item> items)
        {
            _dataStore = new List<Item>(items);
            _position = 0;
        }

        public Item Next()
        {
            if (End())
                return null;

            return _dataStore[_position++];
        }

        public bool End()
        {
            return _position > _dataStore.Count - 1;
        }
    }
}
