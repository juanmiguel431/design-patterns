namespace DesignPatters.Models.Persons;

public class PersonFacetedBuilder
{
    // Reference
    protected Person Person = new();
    
    public PersonFacetedBuilder SetFirstName(string firstName)
    {
        Person.FirstName = firstName;
        return this;
    }
    
    public PersonFacetedBuilder SetMiddleName(string middleName)
    {
        Person.MiddleName = middleName;
        return this;
    }
    
    public PersonFacetedBuilder SetLastName(string lastName)
    {
        Person.LastName = lastName;
        return this;
    }
    
    public PersonAddressBuilder Address => new(Person);
    public PersonLocationBuilder Location => new(Person);
    public Person Build() => Person;
    
    public static implicit operator Person(PersonFacetedBuilder pb) => pb.Person;
}