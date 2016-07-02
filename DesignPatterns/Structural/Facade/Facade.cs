using System;

namespace DesignPatterns.Structural.Facade
{
    class Facade : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Facade pattern--\n");

            var cMajor = new CmajorChord();
            cMajor.Play();

            Console.WriteLine();
        }
    }
}
