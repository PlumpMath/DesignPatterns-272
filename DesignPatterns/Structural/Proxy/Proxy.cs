using System;

namespace DesignPatterns.Structural.Proxy
{
    // In this pattern we will use a proxy class for the loading of a movie, which
    // we will deem as an expensive operation for no logical reason.
    class Proxy : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Proxy pattern--\n");

            const string name = "Hugo";

            var movie = new ProxyMovie(name);
            movie.Play();

            Console.WriteLine();
        }
    }
}
