namespace DesignPatters.Models;

public class Person
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }

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

public class Employee : Person
{
    public string Company { get; set; }
    public string Position { get; set; }
    
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

public class PersonBuilder : PersonBuilder<PersonBuilder, Person>
{
}

public abstract class PersonBuilder<TBuilder, TEntity>
    where TBuilder : PersonBuilder<TBuilder, TEntity>
    where TEntity : Person, new()
{
    protected TEntity Person { get; private set; } = new ();

    public TEntity Build() => Person;

    public TBuilder SetFirstName(string firstName)
    {
        Person.FirstName = firstName;
        return (TBuilder)this;
    }

    public TBuilder SetMiddleName(string middleName)
    {
        Person.MiddleName = middleName;
        return (TBuilder)this;
    }

    public TBuilder SetLastName(string lastName)
    {
        Person.LastName = lastName;
        return (TBuilder)this;
    }
}

public class EmployeeBuilder : PersonBuilder<EmployeeBuilder, Employee>
{
    public EmployeeBuilder SetPosition(string position)
    {
        Person.Position = position;
        return this;
    }

    public EmployeeBuilder SetCompany(string company)
    {
        Person.Company = company;
        return this;
    }
}