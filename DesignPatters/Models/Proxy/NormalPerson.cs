namespace DesignPatters.Models.Proxy;

public class NormalPerson
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


public class ResponsiblePerson
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