namespace DesignPatters.Models.Persons;

public class Relationships : IRelationshipBrowser
{
    private readonly List<(Person, Relationship, Person)> _relations = new();

    public void AddParentAndChild(Person parent, Person child)
    {
        _relations.Add((parent, Relationship.Parent, child));
        _relations.Add((child, Relationship.Child, parent));
    }
    
    public IEnumerable<(Person, Relationship, Person)> FindAllChildrenOf(string name)
    {
        foreach (var r in _relations.Where(p => p.Item1.FirstName == name && p.Item2 == Relationship.Parent))
        {
            yield return r;
        }
    }
}