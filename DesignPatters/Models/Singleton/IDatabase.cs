namespace DesignPatters.Models.Singleton;

public interface IDatabase
{
    public int GetPopulation(string name);
}