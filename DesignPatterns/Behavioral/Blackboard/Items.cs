namespace DesignPatterns.Behavioral.Blackboard
{
    class ItemOfInterest
    {
        public ProblemType ProblemType { get; set; }
        public ItemState State { get; set; }
        public string Name { get; set; }
    }

    enum ProblemType
    {
        Scientific,
        Economical,
        Philosophical,
        Solved
    }

    enum ItemState
    {
        Available,
        Processing,
        Processed
    }
}
