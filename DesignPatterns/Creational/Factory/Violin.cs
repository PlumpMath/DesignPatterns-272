using System;

namespace DesignPatterns.Creational.Factory
{
    class Violin : IInstrument
    {
        public void Play()
        {
            Console.WriteLine("Violin is playing.");
        }
    }
}