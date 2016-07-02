namespace DesignPatterns.Behavioral.Strategy
{
    class Customer
    {
        private IBillingStrategy _strategy;

        public Customer(IBillingStrategy strategy)
        {
            _strategy = strategy;
            Time = 0;
        }

        public int Time { get; set; }

        public decimal GetBill()
        {
            return _strategy.GetPrice(Time);
        }
    }
}
