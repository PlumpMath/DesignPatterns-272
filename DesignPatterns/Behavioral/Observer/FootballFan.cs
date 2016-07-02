using System;

namespace DesignPatterns.Behavioral.Observer
{
    interface IFootballFan
    {
        void Notify(FootballEvent footballEvent);
    }

    class CasualSupporter : IFootballFan
    {
        public void Notify(FootballEvent footballEvent)
        {
            switch (footballEvent)
            {
                case FootballEvent.Goal:
                    Console.WriteLine("Casual football supporter cheers.");
                    break;
                case FootballEvent.GameFinished:
                    Console.WriteLine("Casual football supporter leaves stadium gracefully.");
                    break;
            }
        }
    }

    class Hooligan : IFootballFan
    {
        public void Notify(FootballEvent footballEvent)
        {
            switch (footballEvent)
            {
                case FootballEvent.Goal:
                    Console.WriteLine("Football hooligan lights up a flare and throws it onto the pitch.");
                    break;
                case FootballEvent.GameFinished:
                    Console.WriteLine("Football hooligan leaves stadium, punching anyone he sees and searching for a bar to demolish upon exit.");
                    break;
            }
        }
    }
}
