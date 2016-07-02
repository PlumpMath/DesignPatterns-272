namespace DesignPatterns.Behavioral.Specification
{
    interface ISpecification<T>
    {
        bool IsSatisfiedBy(T candidate);
        ISpecification<T> And(ISpecification<T> other);
        ISpecification<T> Or(ISpecification<T> other);
        ISpecification<T> Not();
    }

    abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T candidate);

        public ISpecification<T> And(ISpecification<T> other)
        {
            return new AndSpecification<T>(this, other);
        }
        
        public ISpecification<T> Not()
        {
            return new NotSpecification<T>(this);
        }

        public ISpecification<T> Or(ISpecification<T> other)
        {
            return new OrSpecification<T>(this, other);
        }
    }

    class AndSpecification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> _left;
        private ISpecification<T> _right;

        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return _left.IsSatisfiedBy(candidate) && _right.IsSatisfiedBy(candidate);
        }
    }

    class OrSpecification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> _left;
        private ISpecification<T> _right;

        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return _left.IsSatisfiedBy(candidate) || _right.IsSatisfiedBy(candidate);
        }
    }

    class NotSpecification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> _specification;

        public NotSpecification(ISpecification<T> specification)
        {
            _specification = specification;
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return !_specification.IsSatisfiedBy(candidate);
        }
    }
}
