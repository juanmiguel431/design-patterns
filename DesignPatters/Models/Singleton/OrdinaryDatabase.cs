using MoreLinq;

namespace DesignPatters.Models.Singleton;

public class OrdinaryDatabase : IDatabase
{
    private Dictionary<string, int>? _capitals;

    private static readonly Lazy<Task<OrdinaryDatabase>> LazyInstance = new(async () =>
    {
        var db = new OrdinaryDatabase();
        await db.InitializeAsync();
        return db;
    });
    
    public static Task<OrdinaryDatabase> Instance => LazyInstance.Value;

    private OrdinaryDatabase()
    {
    }

    private async Task InitializeAsync()
    {
        Console.WriteLine("Initializing Database");
        await Task.Delay(3000);
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