namespace DesignPatterns.Creational.RAII
{
    class Breath
    {
        public bool HasBreath { get; private set; }

        public void Inhale()
        {
            HasBreath = true;
        }

        public void Exhale()
        {
            HasBreath = false;
        }
    }
}
