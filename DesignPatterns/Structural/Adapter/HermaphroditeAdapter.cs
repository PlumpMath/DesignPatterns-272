namespace DesignPatterns.Structural.Adapter
{
    class HermaphroditeAdapter
    {
        private readonly Man _man;
        private readonly Woman _woman;

        public HermaphroditeAdapter()
        {
            _man = new Man();
            _woman = new Woman();
        }

        public void Live()
        {
            _man.Live();
            _woman.Live();
        }
    }
}
