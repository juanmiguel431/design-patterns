namespace DesignPatters.Models.Persons.Relations;

public interface IRelationshipBrowser
{
    IEnumerable<(Person, Relationship, Person)> FindAllChildrenOf(string name);
}