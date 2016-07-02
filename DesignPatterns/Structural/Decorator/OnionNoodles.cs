using System.Collections.Generic;

namespace DesignPatterns.Structural.Decorator
{
    class OnionNoodles : VegetableNoodles
    {
        public OnionNoodles(INoodles noodles) : base(noodles)
        {
            _noodles.Ingredients.Add("Onion");
        }

        public override IList<string> Ingredients
        {
            get { return _noodles.Ingredients; }
        }

        public override int Price()
        {
            return _noodles.Price() + 60;
        }
    }
}
