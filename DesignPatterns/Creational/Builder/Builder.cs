using System;

namespace DesignPatterns.Creational.Builder
{
    class Builder : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Builder pattern--\n");

            // Call the director to build his/her respective ball. 
            Console.WriteLine("Basketball director: " + GetBallDetails(new BasketballDirector().Construct()));
            Console.WriteLine("Football director: "   + GetBallDetails(new FootballDirector()  .Construct()));
            Console.WriteLine("Handball director: "   + GetBallDetails(new HandballDirector()  .Construct()));

            Console.WriteLine();
        }


        private static string GetBallDetails(Ball ball)
        {
            return "The ball has radius " + ball.Radius + ", and weight " + ball.Weight;
        }
    }
}
