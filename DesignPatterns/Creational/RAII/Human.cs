using System;

namespace DesignPatterns.Creational.RAII
{
    // The human is going to be doing RAII. As we don't have destructors in C#, we're going to be using IDisposable
    // The resource in question, is breath. Inhaling is creating the resource, exhaling is releasing. 
    class Human : IDisposable
    {
        public Human()
        {
            Breath = new Breath();
            Breath.Inhale();
        }

        public Breath Breath { get; private set; }

        public void Dispose()
        {
            Breath.Exhale();            
        }
    }
}
