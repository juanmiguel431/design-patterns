namespace DesignPatters.Models.Persons.Employees;

public class Employee : Person, IPrototype<Employee>, IDeepCopyable<Employee>
{
    public string Company { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public string[] Responsibilities { get; set; } = [];

    public Employee()
    {
    }
    
    public Employee(Employee other) : base(other)
    {
        Company = other.Company;
        Position = other.Position;
        Salary = other.Salary;
        Responsibilities = (string[])other.Responsibilities.Clone();
    }

    public new static EmployeeBuilder Builder() => new();
    public new static EmployeeFunctionalBuilder FunctionalBuilder() => new();

    public override Employee DeepCopy()
    {
        return new Employee(this);
    }

    public override string ToString()
    {
        return
            $"{{\n" +
            $" {base.ToString()}" +
            $" {nameof(Company)}: {Company},\n" +
            $" {nameof(Position)}: {Position},\n" +
            $" {nameof(Salary)}: {Salary},\n" +
            $" {nameof(Responsibilities)}: {string.Join(",", Responsibilities)}\n" +
            $"}}";
    }

    public void CopyTo(Employee target)
    {
        base.CopyTo(target);
        target.Company = Company;
        target.Position = Position;
        target.Salary = Salary;
        target.Responsibilities = (string[])Responsibilities.Clone();
    }
}