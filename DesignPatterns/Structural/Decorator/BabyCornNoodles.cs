using System.Collections.Generic;

namespace DesignPatterns.Structural.Decorator
{
    class BabyCornNoodles : VegetableNoodles
    {
        public BabyCornNoodles(INoodles noodles) : base(noodles)
        {
            _noodles.Ingredients.Add("Baby corn");
        }

        public override IList<string> Ingredients
        {
            get { return _noodles.Ingredients; }
        }

        public override int Price()
        {
            return _noodles.Price() + 30;
        }
    }
}
