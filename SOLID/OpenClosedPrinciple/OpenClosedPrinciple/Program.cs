using System;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Red, Size.Medium);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var productFilter = new ProductFilter();

            Console.WriteLine($"Green products (old):");

            foreach (var p in productFilter.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is green.");
            }


            var betterFilter = new BetterFilter();
            Console.WriteLine($"Green products (new):");

            foreach (var p in betterFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green.");
            }

            Console.WriteLine($"Large blue items");

            foreach (var p in betterFilter.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - {p.Name} is blue and large.");

            }
        }
    }
}