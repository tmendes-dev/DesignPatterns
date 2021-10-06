using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            public Research(IRelationshipBrowser browser)
            {
                foreach (var p in browser.FindAllChildrenOf("John"))
                    Console.WriteLine($"John has a child called {p.Name}");
            }

            var parent = new Person() { Name = "John" };
            var child1 = new Person() { Name = "Josh" };
            var child2 = new Person() { Name = "Mary" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);
        }
    }
}
