using System;

namespace DesignPatterns.Behavioral.Servant
{
    class Servant : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Servant pattern--\n");

            var codePoet = new CodePoet();
            var manager = new Manager();
            var president = new President();
            var ceo = new CEO();

            // hr is the servant in our example
            var hr = new HR();

            hr.Pay(codePoet, 10M);
            hr.Pay(manager, 100M);
            hr.Pay(president, 1000M);
            hr.Pay(ceo, 10000M);

            Console.WriteLine();
        }
    }
}
