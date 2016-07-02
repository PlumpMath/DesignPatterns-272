using System;

namespace DesignPatterns.Structural.Bridge
{
    // Concrete implementor
    class Inconsolata : IFont
    {
        public void Write(string text)
        {
            Console.WriteLine("Writing \"" + text + "\" in Inconsolata.");
        }
    }
}
