namespace DesignPatters.Models;

public class PersonFunctionalBuilder : FunctionalBuilder<PersonFunctionalBuilder, Person>
{
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
}

public static class PersonFunctionalBuilderExtensions
{
    public static PersonFunctionalBuilder AddFullName(this PersonFunctionalBuilder builder, string firstName, string middleName, string lastName)
    {
        return builder.SetFirstName(firstName)
            .SetMiddleName(middleName)
            .SetLastName(lastName);
    }
}