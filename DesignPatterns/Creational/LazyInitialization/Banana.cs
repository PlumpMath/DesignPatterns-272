namespace DesignPatterns.Creational.LazyInitialization
{
    // We are going to use a banana as the lazy initialization object.
    // The idea is simple: an initialized banana is one that has been 
    // peeled. If we peel the banana in the constructor, then it's not lazy.
    // Say nay to prepeeling bananas!
    class Banana
    {
        private PeeledBanana _peeledBanana;

        public void Consume()
        {
            // Lazy load!
            if (_peeledBanana == null)
                _peeledBanana = new PeeledBanana();

            _peeledBanana.Eat();
        }

        // This is purely a check so that we can see if we have been 
        // loaded or not
        public bool IsLoaded()
        {
            return _peeledBanana != null;
        }
    }
}
