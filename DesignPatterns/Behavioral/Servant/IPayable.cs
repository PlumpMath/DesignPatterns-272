namespace DesignPatterns.Behavioral.Servant
{
    interface IPayable
    {
        string Name { get; }
        decimal Money { get; set; }
    }
}
