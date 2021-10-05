using OpenClosedPrinciple.Interface;
using System;

namespace OpenClosedPrinciple
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(nameof(first));
            this.second = second ?? throw new ArgumentNullException(nameof(second));
        }

        public bool isSatisfied(T t)
        {
            return first.isSatisfied(t) && second.isSatisfied(t);
        }
    }
}