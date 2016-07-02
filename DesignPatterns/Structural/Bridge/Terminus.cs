using System;

namespace DesignPatterns.Structural.Bridge
{
    // Concrete implementor
    class Terminus : IFont
    {
        public void Write(string text)
        {
            Console.WriteLine("Writing \"" + text + "\" in Terminus.");
        }
    }
}
