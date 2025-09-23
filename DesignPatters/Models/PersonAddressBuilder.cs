namespace DesignPatters.Models;

public class PersonAddressBuilder : PersonFacetedBuilder
{
    public PersonAddressBuilder(Person person)
    {
        Person = person;
    }
    
    public PersonAddressBuilder SetStreet(string street)
    {
        Person.Street = street;
        return this;
    }
    
    public PersonAddressBuilder SetCity(string city)
    {
        Person.City = city;
        return this;
    }
    
    public PersonAddressBuilder SetState(string state)
    {
        Person.State = state;
        return this;
    }

    public PersonAddressBuilder SetZipCode(string zipCode)
    {
        Person.ZipCode = zipCode;
        return this;
    }
}