namespace DesignPatters.Models.Persons;

public static class PersonFunctionalBuilderExtensions
{
    public static PersonFunctionalBuilder AddFullName(this PersonFunctionalBuilder builder, string firstName, string middleName, string lastName)
    {
        return builder.SetFirstName(firstName)
            .SetMiddleName(middleName)
            .SetLastName(lastName);
    }
}