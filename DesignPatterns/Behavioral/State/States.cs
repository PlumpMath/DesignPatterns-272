using System;

namespace DesignPatterns.Behavioral.State
{
    interface IState
    {
        void Handle(Life context);
    }

    class SleepingState : IState
    {
        public void Handle(Life context)
        {
            Console.WriteLine("Sleeping.");

            context.State = new EatingState();
        }
    }

    class EatingState : IState
    {
        public void Handle(Life context)
        {
            Console.WriteLine("Eating.");

            context.State = new ThinkingState();
        }
    }

    class ThinkingState : IState
    {
        public void Handle(Life context)
        {
            Console.WriteLine("Thinking.");

            context.State = new SleepingState();
        }
    }
}
