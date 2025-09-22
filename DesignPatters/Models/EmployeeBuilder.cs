namespace DesignPatters.Models;

public sealed class EmployeeBuilder : PersonBuilder<EmployeeBuilder, Employee>
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