using System;

namespace DesignPatterns.Structural.Facade
{
    class C : INote
    {
        public void Play()
        {
            Console.WriteLine("C played");
        }
    }
}
