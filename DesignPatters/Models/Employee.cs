namespace DesignPatters.Models;

public class Employee : Person
{
    public string Company { get; set; }
    public string Position { get; set; }

    public new static EmployeeBuilder Builder() => new();
    public new static EmployeeFunctionalBuilder FunctionalBuilder() => new();

    public override string ToString()
    {
        return
            $"{{" +
            $"{nameof(FirstName)}: {FirstName}," +
            $" {nameof(MiddleName)}: {MiddleName}," +
            $" {nameof(LastName)}: {LastName}," +
            $" {nameof(Company)}: {Company}," +
            $" {nameof(Position)}: {Position}" +
            $"}}";
    }
}