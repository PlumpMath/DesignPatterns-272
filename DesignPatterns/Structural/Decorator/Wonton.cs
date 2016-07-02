using System.Collections.Generic;

namespace DesignPatterns.Structural.Decorator
{
    class Wonton : INoodles
    {
        private readonly IList<string> _ingredients;

        public Wonton()
        {
            _ingredients = new List<string>
            {
                "Wonton noodles"
            };
        }

        public IList<string> Ingredients
        {
            get { return _ingredients; }
        }

        public int Price()
        {
            return 110;
        }
    }
}
