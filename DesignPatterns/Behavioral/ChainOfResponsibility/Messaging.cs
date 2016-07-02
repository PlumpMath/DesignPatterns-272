namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    class Message 
    {
        public string Data { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
    }

    enum SecurityLevel
    {
        Public = 0,
        Private = 1, 
        Confidential = 2,
        Secret = 3
    }
}
