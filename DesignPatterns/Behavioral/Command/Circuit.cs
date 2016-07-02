namespace DesignPatterns.Behavioral.Command
{
    class Circuit
    {
        private readonly ICommand _open;
        private readonly ICommand _close;

        public Circuit(ICommand openCommand, ICommand closeCommand)
        {
            _open = openCommand;
            _close = closeCommand;
        }

        public void Open()
        {
            _open.Execute();
        }

        public void Close()
        {
            _close.Execute();
        }
    }
}
