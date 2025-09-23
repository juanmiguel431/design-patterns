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