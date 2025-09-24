namespace DesignPatters.Models.Persons;

public abstract class PersonBuilder<TBuilder, TEntity>
    where TBuilder : PersonBuilder<TBuilder, TEntity>
    where TEntity : Person, new()
{
    protected TEntity Person { get; private set; } = new();

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

public sealed class PersonBuilder : PersonBuilder<PersonBuilder, Person>
{
}