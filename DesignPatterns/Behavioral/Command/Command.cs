using System;

namespace DesignPatterns.Behavioral.Command
{
    class Command : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Command pattern--\n");

            var circuit = new Circuit(new OpenCircuitCommand(), new CloseCircuitCommand());
            circuit.Open();
            circuit.Close();

            Console.WriteLine();
        }
    }
}
