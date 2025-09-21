namespace DesignPatters.Models;

public class Person
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }
    public string Position { get; set; }

    public class Builder : PersonJobBuilder<Builder>
    {
        
    }
    
    public static Builder New => new();
    
    
    public override string ToString()
    {
        return $"{{{nameof(FirstName)}: {FirstName}, {nameof(MiddleName)}: {MiddleName}, {nameof(LastName)}: {LastName}, {nameof(Company)}: {Company}, {nameof(Position)}: {Position}}}";
    }
}

public abstract class PersonBuilder
{
    protected Person Person { get; set; } = new();

    public Person Build()
    {
        return Person;
    }
}

public class PersonInfoBuilder<TSelf> : PersonBuilder where TSelf : PersonInfoBuilder<TSelf>
{
    public TSelf SetFirstName(string firstName)
    {
        Person.FirstName = firstName;
        return (TSelf) this;
    }
    
    public TSelf SetMiddleName(string middleName)
    {
        Person.MiddleName = middleName;
        return (TSelf) this;
    }
    
    public TSelf SetLastName(string lastName)
    {
        Person.LastName = lastName;
        return (TSelf) this;
    }
}

public class PersonJobBuilder<TSelf> : PersonInfoBuilder<PersonJobBuilder<TSelf>> where TSelf : PersonJobBuilder<TSelf>
{
    public TSelf SetPosition(string position)
    {
        Person.Position = position;
        return (TSelf) this;
    }
    
    public TSelf SetCompany(string company)
    {
        Person.Company = company;
        return (TSelf) this;
    }
}