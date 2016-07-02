namespace DesignPatterns.Behavioral.Servant
{
    class CodePoet : IPayable
    {
        public string Name { get { return "Code poet"; } }
        public decimal Money { get; set; }
    }

    class Manager : IPayable
    {
        public string Name { get { return "Manager"; } }
        public decimal Money { get; set; }
    }

    class President : IPayable
    {
        public string Name { get { return "President"; } }
        public decimal Money { get; set; }
    }

    class CEO : IPayable
    {
        public string Name { get { return "CEO"; } }
        public decimal Money { get; set; }
    }
}
