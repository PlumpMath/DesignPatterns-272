namespace DesignPatterns.Behavioral.Specification
{
    class Invoice
    {
        public const int NumberOfSendsAllowed = 3;
        public bool Paid { get; set; }
        public bool Sent { get; set; }
        public int TimesSent { get; set; }
    }

    class NotPaidSpecification : CompositeSpecification<Invoice>
    {
        public override bool IsSatisfiedBy(Invoice candidate)
        {
            return !candidate.Paid;
        }
    }

    class SentSpecification : CompositeSpecification<Invoice>
    {
        public override bool IsSatisfiedBy(Invoice candidate)
        {
            return candidate.Sent;
        }
    }

    class MaximumTriesSentSpecification : CompositeSpecification<Invoice>
    {
        public override bool IsSatisfiedBy(Invoice candidate)
        {
            return candidate.TimesSent == Invoice.NumberOfSendsAllowed;
        }
    }
}
