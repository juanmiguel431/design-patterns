namespace DesignPatters.Models.Animals;

public class Bird : IBird
{
    public int Weight { get; set; }
    public void Fly()
    {
        Console.WriteLine($"Soaring in the skies with its {Weight}kg weight.");
    }
}