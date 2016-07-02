using System;

namespace DesignPatterns.Structural.Facade
{
    class G : INote
    {
        public void Play()
        {
            Console.WriteLine("G played");
        }
    }
}
