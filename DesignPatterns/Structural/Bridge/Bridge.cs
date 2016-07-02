using System;

namespace DesignPatterns.Structural.Bridge
{
    class Bridge : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Bridge pattern--\n");

            var germanTextInInconsolata = new GermanText("Brueckenstrucktur!", new Inconsolata());
            germanTextInInconsolata.Output();

            var germanTextInTerminus = new GermanText("Brueckenbau!", new Terminus());
            germanTextInTerminus.Output();

            var englishTextInInconsolata = new EnglishText("Bridge pattern!", new Inconsolata());
            englishTextInInconsolata.Output();

            var englishTextInTerminus = new EnglishText("Bridge building!", new Terminus());
            englishTextInTerminus.Output();

            Console.WriteLine();
        }
    }
}
