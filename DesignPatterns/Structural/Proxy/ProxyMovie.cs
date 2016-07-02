namespace DesignPatterns.Structural.Proxy
{
    class ProxyMovie : IMovie
    {
        private Movie _movie;

        public ProxyMovie(string name)
        {
            _movie = new Movie(name);            
        }

        public void Play()
        {
            // we could do a lazy initialization here to avoid the 
            // costly loading of the movie, but we will do it 
            // in the ctor for simplicity.

            _movie.Play();
        }
    }
}
