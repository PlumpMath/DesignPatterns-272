using System;

namespace DesignPatterns.Creational.Factory
{
    class Piano : IInstrument
    {
        public void Play()
        {
            Console.WriteLine("Piano is playing.");
        }
    }
}