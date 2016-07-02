using System;

namespace DesignPatterns.Behavioral.Mediator
{
    class Mediator : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Mediator pattern--\n");

            var message = new Message
            {
                Data = "some message\n"
            };

            var mediator = new Regulator(new Component1(), new Component2());
            mediator.Modify(message);

            Console.WriteLine(message.Data);

            Console.WriteLine();
        }
    }
}
