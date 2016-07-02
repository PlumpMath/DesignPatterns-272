using System;

namespace DesignPatterns.Creational.Multiton
{
    class BirthdayParty
    {
        public BirthdayParty(uint age)
        {
            Age = age;
        }
        
        public uint Age { get; }

        public void Celebrate()
        {
            Console.WriteLine("Birthday party at age " + Age + " being celebrated!");
        }
    }
}
