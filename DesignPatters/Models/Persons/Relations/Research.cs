namespace DesignPatters.Models.Persons.Relations;

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
            Console.WriteLine($"John has a child called {r.Item3.FirstName}.");
        }
    }
}