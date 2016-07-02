using System.Collections.Generic;

namespace DesignPatterns.Structural.Decorator
{
    // Decorator pattern. 
    // They are noodles, but they are more complicated noodles with
    // extra vegetables
    abstract class VegetableNoodles : INoodles
    {
        protected INoodles _noodles;

        protected VegetableNoodles(INoodles noodles)
        {
            _noodles = noodles;
        }

        public abstract int Price();

        public abstract IList<string> Ingredients
        {
            get;
        }
    }
}
