namespace DesignPatters.Models.Animals;

public interface ILizard
{
    void Crawl();
    int Weight { get; set; }
}