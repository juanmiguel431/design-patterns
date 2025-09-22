namespace DesignPatters.Models;

public class Person
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }

    public static PersonBuilder Builder() => new();
    public static PersonFunctionalBuilder FunctionalBuilder() => new();

    public override string ToString()
    {
        return
            $"{{" +
            $"{nameof(FirstName)}: {FirstName}," +
            $" {nameof(MiddleName)}: {MiddleName}," +
            $" {nameof(LastName)}: {LastName}" +
            $"}}";
    }
}