using System.Collections.Generic;

namespace DesignPatterns.Structural.Decorator
{
    class LoMein : INoodles
    {
        private readonly IList<string> _ingredients;

        public LoMein()
        {
            _ingredients = new List<string>
            {
                "Lo Mein noodles"
            };
        }

        public IList<string> Ingredients
        {
            get { return _ingredients; }
        }

        public int Price()
        {
            return 90;
        }
    }
}
