namespace DesignPatterns.Structural.Facade
{
    // Facade.
    // The chord is composed of three notes and this 
    // logic is hidden from the caller.
    class CmajorChord
    {
        private INote _root;
        private INote _majorThird;
        private INote _fifth;

        public CmajorChord()
        {
            _root = new C();
            _majorThird = new E();
            _fifth = new G();
        }

        public void Play()
        {
            _root.Play();
            _majorThird.Play();
            _fifth.Play();
        }
    }
}
