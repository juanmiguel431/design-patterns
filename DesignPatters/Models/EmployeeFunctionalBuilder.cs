namespace DesignPatters.Models;

public sealed class EmployeeFunctionalBuilder : PersonFunctionalBuilder<EmployeeFunctionalBuilder, Employee>
{
    public EmployeeFunctionalBuilder SetCompany(string company)
    {
        return Do(person => person.Company = company);
    }

    public EmployeeFunctionalBuilder SetPosition(string position)
    {
        return Do(person => person.Position = position);
    }
}