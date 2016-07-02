namespace DesignPatterns.Creational.Builder
{
    class BasketballDirector
    {
        public Ball Construct()
        {
            return 
                new BallBuilder()
                .SetRadius(10)
                .SetWeight(10)
                .GetResult();
        }
    }
}
