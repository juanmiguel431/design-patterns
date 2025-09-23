namespace DesignPatters.Models;

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