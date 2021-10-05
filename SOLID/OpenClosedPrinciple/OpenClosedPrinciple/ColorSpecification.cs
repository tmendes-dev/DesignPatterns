using OpenClosedPrinciple.Interface;
using System;

namespace OpenClosedPrinciple
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color Color { get; set; }

        public ColorSpecification(Color color)
        {
            Color = color;
        }

        public bool isSatisfied(Product t)
        {
            return t.Color == Color;
        }
    }
}