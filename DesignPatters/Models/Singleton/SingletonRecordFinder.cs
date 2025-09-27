namespace DesignPatters.Models.Singleton;

public class SingletonRecordFinder
{
    public int GetTotalPopulationAsync(IEnumerable<string> names)
    {
        var total = 0;
        foreach (var name in names)
        {
            total += SingletonDatabase.Instance.GetPopulation(name);
        }
        
        return total;
    }
}