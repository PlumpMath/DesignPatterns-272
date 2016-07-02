using System;

namespace DesignPatterns.Behavioral.Strategy
{
    class Strategy : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Strategy pattern--\n");

            var normalCustomer = new Customer(new NormalBillingStrategy());
            normalCustomer.Time++;
            normalCustomer.Time++;
            normalCustomer.Time++;
            normalCustomer.Time++;
            Console.WriteLine("Normal customer. Time: " + normalCustomer.Time + ", Bill: " + normalCustomer.GetBill());

            var nightCustomer = new Customer(new NightBillingStrategy());
            nightCustomer.Time++;
            nightCustomer.Time++;
            nightCustomer.Time++;
            nightCustomer.Time++;
            nightCustomer.Time++;
            Console.WriteLine("Night customer. Time: " + nightCustomer.Time + ", Bill: " + nightCustomer.GetBill());

            Console.WriteLine();
        }
    }
}
