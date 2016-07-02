using System.Collections.Generic;

namespace DesignPatterns.Structural.Decorator
{
    class MushroomNoodles : VegetableNoodles
    {
        public MushroomNoodles(INoodles noodles) : base(noodles)
        {
            _noodles.Ingredients.Add("Mushroom");
        }

        public override IList<string> Ingredients
        {
            get { return _noodles.Ingredients; }
        }

        public override int Price()
        {
            return _noodles.Price() + 20;
        }
    }
}
