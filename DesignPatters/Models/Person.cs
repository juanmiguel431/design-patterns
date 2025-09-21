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
public class Relationships
{
    private readonly List<(Person, Relationship, Person)> _relations = new();
    public List<(Person, Relationship, Person)> Relations => _relations;

    public void AddParentAndChild(Person parent, Person child)
    {
        _relations.Add((parent, Relationship.Parent, child));
        _relations.Add((child, Relationship.Child, parent));
    }
}

public class Research
{
    public Research(Relationships relationships)
    {
        var relations = relationships.Relations;
        foreach (var r in relations.Where(p => p.Item1.Name == "John" && p.Item2 == Relationship.Parent))
        {
            Console.WriteLine($"John has a child called {r.Item3.Name}.");
        }
    }
}