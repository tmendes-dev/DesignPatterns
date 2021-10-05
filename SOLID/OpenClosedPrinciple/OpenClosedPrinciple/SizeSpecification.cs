using OpenClosedPrinciple.Interface;

namespace OpenClosedPrinciple
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size Size { get; set; }

        public SizeSpecification(Size size)
        {
            Size = size;
        }

        public bool isSatisfied(Product t)
        {
            return t.Size == Size;
        }
    }
}