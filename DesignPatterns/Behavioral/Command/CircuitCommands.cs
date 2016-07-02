using System;

namespace DesignPatterns.Behavioral.Command
{
    class OpenCircuitCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Opened circuit.");
        }
    }

    class CloseCircuitCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Closed circuit.");
        }
    }
}
