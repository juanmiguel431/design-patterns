namespace DesignPatters.Models;

public interface IRelationshipBrowser
{
    IEnumerable<(Person, Relationship, Person)> FindAllChildrenOf(string name);
}