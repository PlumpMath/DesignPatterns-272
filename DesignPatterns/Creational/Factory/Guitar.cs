using System;

namespace DesignPatterns.Creational.Factory
{
    class Guitar : IInstrument
    {
        public void Play()
        {
            Console.WriteLine("Guitar is playing.");
        }
    }
}