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