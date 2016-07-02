namespace DesignPatterns.Behavioral.Mediator
{
    class Regulator
    {
        IComponent _component1;
        IComponent _component2;

        public Regulator(IComponent component1, IComponent component2)
        {
            _component1 = component1;
            _component2 = component2;
        }

        public void Modify(Message message)
        {
            _component1.Edit(message);
            _component2.Edit(message);
        }
    }
}
