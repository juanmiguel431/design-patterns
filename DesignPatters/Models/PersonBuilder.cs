namespace DesignPatters.Models;

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

public class PersonFunctionalBuilder
{
    private readonly List<Func<Person, Person>> _actions = [];

    public PersonFunctionalBuilder SetFirstName(string firstName)
    {
        return Do(person => person.FirstName = firstName);
    }
    
    public PersonFunctionalBuilder SetMiddleName(string middleName)
    {
        return Do(person => person.MiddleName = middleName);
    }
    
    public PersonFunctionalBuilder SetLastName(string lastName)
    {
        return Do(person => person.LastName = lastName);
    }
    
    public PersonFunctionalBuilder Do(Action<Person> action) => AddAction(action);

    public Person Build()
    {
        return _actions.Aggregate(new Person(), (person, action) => action(person));
    }
    
    private PersonFunctionalBuilder AddAction(Action<Person> action)
    {
        _actions.Add(person =>
        {
            action(person);
            return person;
        });
        
        return this;
    }
}