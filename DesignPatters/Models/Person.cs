namespace DesignPatters.Models;

public class Person
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }

    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public float Latitude { get; set; }
    public float Longitude { get; set; }

    public static PersonBuilder Builder() => new();
    public static PersonFunctionalBuilder FunctionalBuilder() => new();
    public static PersonFacetedBuilder PersonFacetedBuilder() => new();

    public override string ToString()
    {
        return
            $"{{\n" +
            $" {nameof(FirstName)}: {FirstName},\n" +
            $" {nameof(MiddleName)}: {MiddleName},\n" +
            $" {nameof(LastName)}: {LastName},\n" +
            $" {nameof(Street)}: {Street}\n" +
            $" {nameof(City)}: {City},\n" +
            $" {nameof(State)}: {State},\n" +
            $" {nameof(ZipCode)}: {ZipCode},\n" +
            $" {nameof(Latitude)}: {Latitude},\n" +
            $" {nameof(Longitude)}: {Longitude}\n" +
            $"}}\n";
    }
}

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
}

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

public class PersonLocationBuilder : PersonFacetedBuilder
{
    public PersonLocationBuilder(Person person)
    {
        Person = person;
    }
    
    public PersonLocationBuilder SetLatitude(float latitude)
    {
        Person.Latitude = latitude;
        return this;
    }
    
    public PersonLocationBuilder SetLongitude(float longitude)
    {
        Person.Longitude = longitude;
        return this;
    }
}