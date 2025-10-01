namespace DesignPatters.Models.Animals;

public interface IReptile : ICreature
{
    public void Crawl()
    {
        if (Age < 10)
        {
            Console.WriteLine("I am crawling!");
        }
    }
}