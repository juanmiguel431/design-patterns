namespace DesignPatters.Models;

public class Person
{
    public string Name { get; set; }
    public string Position { get; set; }

    public class Builder : PersonJobBuilder<Builder>
    {
        
    }
    
    public static Builder New => new();
    
    
    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
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
    public TSelf Called(string name)
    {
        Person.Name = name;
        return (TSelf) this;
    }
}

public class PersonJobBuilder<TSelf> : PersonInfoBuilder<PersonJobBuilder<TSelf>> where TSelf : PersonJobBuilder<TSelf>
{
    public TSelf WorksAsA(string position)
    {
        Person.Position = position;
        return (TSelf) this;
    }
}