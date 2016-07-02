using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Visitor
{
    interface ICarElement
    {
        void Accept(ICarElementVisitor visitor);
    }

    class Wheel : ICarElement
    {
        public Wheel(int index)
        {
            Index = index;
        }

        public int Index { get; private set; }

        public void Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    class Body : ICarElement
    {
        public void Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    class Engine : ICarElement
    {
        public void Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    class Car : ICarElement
    {
        private readonly List<ICarElement> _subparts;

        public Car()
        {
            _subparts = new List<ICarElement>
            {
                new Wheel(0), new Wheel(1),
                new Wheel(2), new Wheel(4),
                new Body(), new Engine()
            };
        }

        public void Accept(ICarElementVisitor visitor)
        {
            foreach (var part in _subparts)
                part.Accept(visitor);

            visitor.Visit(this);
        }
    }
}
