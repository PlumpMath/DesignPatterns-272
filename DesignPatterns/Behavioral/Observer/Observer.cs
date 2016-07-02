using System;

namespace DesignPatterns.Behavioral.Observer
{
    class Observer : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Observer pattern--\n");

            var casualSupporter = new CasualSupporter();
            var casualSupporter2 = new CasualSupporter();
            var hooligan = new Hooligan();

            var footballGame = new FootballGame();
            footballGame.AddSupporter(casualSupporter);
            footballGame.AddSupporter(casualSupporter2);
            footballGame.AddSupporter(hooligan);

            footballGame.Notify(FootballEvent.Goal);
            footballGame.Notify(FootballEvent.Goal);
            footballGame.Notify(FootballEvent.GameFinished);

            footballGame.RemoveSupporter(casualSupporter);
            footballGame.RemoveSupporter(casualSupporter2);
            footballGame.RemoveSupporter(hooligan);

            Console.WriteLine();
        }
    }
}
