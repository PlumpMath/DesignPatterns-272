using System;

namespace DesignPatterns.Structural.Proxy
{
    class Movie : IMovie
    {
        private readonly string _name;

        public Movie(string name)
        {
            _name = name;
            Load();
        }

        public void Play()
        {
            Console.WriteLine("Playing film " + _name);
        }

        private void Load()
        {
            Console.WriteLine("Loading film " + _name);
        }
    }
}