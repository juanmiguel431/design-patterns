namespace DesignPatters.Models.Persons;

public interface IRelationshipBrowser
{
    IEnumerable<(Person, Relationship, Person)> FindAllChildrenOf(string name);
}