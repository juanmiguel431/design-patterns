namespace DesignPatters.Models;

public abstract class PersonFunctionalBuilder<TBuilder, TEntity> : FunctionalBuilder<TBuilder, TEntity>
    where TBuilder : PersonFunctionalBuilder<TBuilder, TEntity>
    where TEntity : Person, new()
{
    public TBuilder SetFirstName(string firstName)
    {
        return Do(person => person.FirstName = firstName);
    }
    
    public TBuilder SetMiddleName(string middleName)
    {
        return Do(person => person.MiddleName = middleName);
    }
    
    public TBuilder SetLastName(string lastName)
    {
        return Do(person => person.LastName = lastName);
    }
}

public sealed class PersonFunctionalBuilder : PersonFunctionalBuilder<PersonFunctionalBuilder, Person>
{
}