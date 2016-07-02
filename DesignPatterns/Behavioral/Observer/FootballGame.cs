using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    enum FootballEvent
    {
        Goal,
        GameFinished
    }

    class FootballGame
    {
        private readonly List<IFootballFan> _fans = new List<IFootballFan>();

        public void AddSupporter(IFootballFan fan)
        {
            _fans.Add(fan);
        }

        public void RemoveSupporter(IFootballFan fan)
        {
            _fans.Remove(fan);
        }

        public void Notify(FootballEvent footballEvent)
        {
            foreach (var fan in _fans)
            {
                fan.Notify(footballEvent);
            }
        }
    }
}
