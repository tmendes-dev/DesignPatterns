using OpenClosedPrinciple.Interface;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    internal class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
            {
                if (spec.isSatisfied(i))
                    yield return i;
            }
        }
    }
}