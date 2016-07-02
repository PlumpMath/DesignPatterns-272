namespace DesignPatterns.Creational.Builder
{
    class HandballDirector
    {
        public Ball Construct()
        {
            return 
                new BallBuilder()
                .SetRadius(3)
                .SetWeight(8)
                .GetResult();
        }
    }
}
