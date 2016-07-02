using System;

namespace DesignPatterns.Behavioral.Specification
{
    // Business logic using boolean algebra
    //
    // Couldn't think of a meaningful example so this is basically the Wikipedia one
    class Specification : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Specification pattern--\n");

            var notPaid = new NotPaidSpecification();
            var sent = new SentSpecification();
            var maxTriesExceeded = new MaximumTriesSentSpecification();

            var specification = notPaid.And(sent.And(maxTriesExceeded.Not()));

            var invoice = new Invoice
            {
                Paid = false,
                Sent = true,
                TimesSent = 2
            };

            var shouldSend = specification.IsSatisfiedBy(invoice);

            Console.WriteLine("Should send invoice: " + shouldSend);

            invoice.TimesSent++;

            var shouldSendAgain = specification.IsSatisfiedBy(invoice);
            Console.WriteLine("Should send invoice: " + shouldSendAgain);

            Console.WriteLine();
        }
    }




}
