using System;

namespace DesignPatterns.Behavioral.NullObject
{
    interface IBeer
    {
        void Drink();
    }

    class FullBeer : IBeer
    {
        public void Drink()
        {
            Console.WriteLine("Drinking beer.");
        }
    }

    // this is our version of a null object
    class EmptyBeer : IBeer
    {
        public void Drink()
        {
            // no drinking
        }
    }
}
