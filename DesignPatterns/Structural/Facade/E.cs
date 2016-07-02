using System;

namespace DesignPatterns.Structural.Facade
{
    class E : INote
    {
        public void Play()
        {
            Console.WriteLine("E played");
        }
    }
}
