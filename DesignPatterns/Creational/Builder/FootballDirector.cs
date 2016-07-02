namespace DesignPatterns.Creational.Builder
{
    class FootballDirector
    {
        public Ball Construct()
        {
            return
                new BallBuilder()
                .SetRadius(8)
                .SetWeight(6)
                .GetResult();
        }
    }
}
