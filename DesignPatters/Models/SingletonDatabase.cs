using MoreLinq;

namespace DesignPatters.Models;

public class SingletonDatabase : IDatabase
{
    private readonly Dictionary<string, int> _capitals;

    private static readonly Lazy<SingletonDatabase> _instance = new(() => new SingletonDatabase());
    public static SingletonDatabase Instance => _instance.Value;

    private SingletonDatabase()
    {
        Console.WriteLine("Initializing Database");

        _capitals = File.ReadAllLines("capitals.txt")
            .Batch(2)
            .ToDictionary(l =>
                    l.ElementAt(0).Trim(),
                l => int.Parse(l.ElementAt(1).Trim()));
    }
    
    public int GetPopulation(string name)
    {
        return _capitals[name];
    }
}