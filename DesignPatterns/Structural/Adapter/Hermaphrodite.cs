using System;

namespace DesignPatterns.Structural.Adapter
{
    // Hermaphrodite will be using the adapter pattern for 
    // multiple inheritence, as it's both a man and a woman
    class Hermaphrodite
    {
        private readonly HermaphroditeAdapter _adapter;
        public Hermaphrodite()
        {
            _adapter = new HermaphroditeAdapter();
        }

        public void Live()
        {
            Console.WriteLine("Hermaphrodite: ");
            _adapter.Live();
        }
    }
}
