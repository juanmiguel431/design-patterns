namespace DesignPatters.Models;

public class Person
{
    public string Name { get; set; }
}

public enum Relationship
{
    Parent,
    Child,
    Sibling
}

// Low Level Module
public interface IRelationshipBrowser
{
    IEnumerable<(Person, Relationship, Person)> FindAllChildrenOf(string name);
}

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
        foreach (var r in _relations.Where(p => p.Item1.Name == name && p.Item2 == Relationship.Parent))
        {
            yield return r;
        }
    }
}

public class Research
{
    private readonly IRelationshipBrowser _relationshipBrowser;

    public Research(IRelationshipBrowser relationshipBrowser)
    {
        _relationshipBrowser = relationshipBrowser;
    }

    public void PrintAllChildrenOf(string name)
    {
        foreach (var r in _relationshipBrowser.FindAllChildrenOf(name))
        {
            Console.WriteLine($"John has a child called {r.Item3.Name}.");
        }
    }
}