using System.Collections.Generic;

namespace DesignPatterns.Structural.Decorator
{
    interface INoodles
    {
        IList<string> Ingredients { get; }
        int Price();
    }
}
