namespace DesignPatters.Models.Proxy;

public interface INormalPerson
{
    int Age { get; set; }
    string Drink();
    string Drive();
    string DrinkAndDrive();
}

public class NormalPerson : INormalPerson
{
    public int Age { get; set; }

    public string Drink()
    {
        return "drinking";
    }

    public string Drive()
    {
        return "driving";
    }

    public string DrinkAndDrive()
    {
        return "driving while drunk";
    }
}


public class ResponsiblePerson : INormalPerson
{
    private readonly NormalPerson _person;
    
    public string Drink()
    {
        if (_person.Age < 18) return "too young";
        return _person.Drink();
    }

    public string Drive()
    {
        if (_person.Age < 16) return "too young";
        return _person.Drive();
    }

    public string DrinkAndDrive()
    {
        return "dead";
    }

    public ResponsiblePerson(NormalPerson person)
    {
        _person = person;
    }
      
    public int Age
    {
        get => _person.Age;
        set => _person.Age = value;
    }
}

// Allows person to drink unless they are younger than 18 (in that case, return "too young")
// Allows person to drive unless they are younger than 16 (otherwise, "too young")
// In case of driving while drinking, returns "dead"