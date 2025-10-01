namespace DesignPatters.Models.Animals;

public class Lizard : ILizard
{
    public int Weight { get; set; }
    public void Crawl()
    {
        Console.WriteLine($"Crawling in the dirt with its {Weight}kg weight.");
    }
}