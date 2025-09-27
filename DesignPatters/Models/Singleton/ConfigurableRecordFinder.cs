namespace DesignPatters.Models.Singleton;

public class ConfigurableRecordFinder
{
    private readonly IDatabase _database;

    public ConfigurableRecordFinder(IDatabase database)
    {
        _database = database;
    }
    
    public int GetTotalPopulationAsync(IEnumerable<string> names)
    {
        var total = 0;
        foreach (var name in names)
        {
            total += _database.GetPopulation(name);
        }
        
        return total;
    }
}

public class DummyDatabase : IDatabase
{
    public int GetPopulation(string name)
    {
        return new Dictionary<string, int>()
        {
            ["Alpha"] = 1,
            ["Beta"] = 2,
            ["Gamma"] = 3,
        }[name];
    }
}