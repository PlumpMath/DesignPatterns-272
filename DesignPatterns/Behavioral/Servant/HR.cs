using System;

namespace DesignPatterns.Behavioral.Servant
{
    class HR
    {
        public void Pay(IPayable payable, decimal pay)
        {
            payable.Money += pay;

            Console.WriteLine(payable.Name + " paid " + pay);
        }
    }
}
