namespace DesignPatters.Models.Animals;

public interface IBird
{
    void Fly();
    int Weight { get; set; }
}