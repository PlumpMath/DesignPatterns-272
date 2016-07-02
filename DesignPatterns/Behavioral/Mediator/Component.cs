namespace DesignPatterns.Behavioral.Mediator
{
    interface IComponent
    {
        void Edit(Message message);
    }

    class Component1 : IComponent
    {
        public void Edit(Message message)
        {
            message.Data += "c1 was here...\n";
        }
    }

    class Component2 : IComponent
    {
        public void Edit(Message message)
        {
            message.Data += "c2 was here...\n";
        }
    }
}
