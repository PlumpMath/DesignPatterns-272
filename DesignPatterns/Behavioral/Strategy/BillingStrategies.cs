namespace DesignPatterns.Behavioral.Strategy
{
    interface IBillingStrategy
    {
        decimal GetPrice(int timeSpent);
    }

    class NightBillingStrategy : IBillingStrategy
    {
        public decimal GetPrice(int timeSpent)
        {
            return timeSpent * 2;
        }
    }

    class NormalBillingStrategy : IBillingStrategy
    {
        public decimal GetPrice(int timeSpent)
        {
            return timeSpent * 1;
        }
    }
}
