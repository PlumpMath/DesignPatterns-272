using System;

namespace DesignPatterns.Creational.Multiton
{
    class Multiton : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Multiton pattern--\n");

            BirthdayParties.GetBirthdayParty(0).Celebrate();
            BirthdayParties.GetBirthdayParty(5).Celebrate();
            BirthdayParties.GetBirthdayParty(10).Celebrate();
            BirthdayParties.GetBirthdayParty(15).Celebrate();
            BirthdayParties.GetBirthdayParty(100).Celebrate();

            Console.WriteLine();
        }
    }
}
