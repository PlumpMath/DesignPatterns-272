namespace DesignPatterns.Behavioral.State
{
    class Life
    {
        public Life()
        {
            State = new SleepingState();
        }

        public IState State { get; set; }

        public void Live()
        {
            State.Handle(this);
        }
    };
}
