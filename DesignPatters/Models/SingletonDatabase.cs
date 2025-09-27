using MoreLinq;

namespace DesignPatters.Models;

public class SingletonDatabase : IDatabase
{
    private Dictionary<string, int>? _capitals;

    private static readonly Lazy<Task<SingletonDatabase>> LazyInstance = new(async () =>
    {
        var db = new SingletonDatabase();
        await db.InitializeAsync();
        return db;
    });
    
    public static Task<SingletonDatabase> Instance => LazyInstance.Value;
    private static int _count = 0;
    public static int Count => _count;

    private SingletonDatabase()
    {
        _count++;
    }

    private async Task InitializeAsync()
    {
        Console.WriteLine("Initializing Database");
        await Task.Delay(1000);
        var data = await File.ReadAllLinesAsync("capitals.txt");
        _capitals = data.Batch(2)
            .ToDictionary(l =>
                    l.ElementAt(0).Trim(),
                l => int.Parse(l.ElementAt(1).Trim()));
    }
    
    public int GetPopulation(string name)
    {
        return _capitals![name];
    }
}