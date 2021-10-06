using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> Relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            Relations.Add((parent, Relationship.Parent, child));
            Relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return from r in Relations.Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent) select r.Item3;
        }
    }
}