namespace DesignPatterns.Creational.Builder
{
    class BallBuilder : IBallBuilder
    {
        private readonly Ball _ball;

        public BallBuilder()
        {
            _ball = new Ball();
        }

        public Ball GetResult()
        {
            return _ball;
        }

        public IBallBuilder SetRadius(int radius)
        {
            _ball.Radius = radius;

            return this;
        }

        public IBallBuilder SetWeight(int weight)
        {
            _ball.Weight = weight;

            return this;
        }
    }
}
