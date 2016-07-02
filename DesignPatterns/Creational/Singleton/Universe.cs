using System;

namespace DesignPatterns.Creational.Singleton
{
    // The universe is a singleton object as there's only one. 
    // *Insert fingers into ears and shout lalala over all the multiverse supporters*
    class Universe
    {
        private static Universe _instance;

        public static Universe GetInstance()
        {
            return _instance ?? (_instance = new Universe());
        }

        private Universe()
        {
        }

        public void BangLikeReallyBig()
        {
            Console.WriteLine("BIG BANG");
        }
    }
}
