namespace DesignPatters.Models.Animals;

public class Drake : Organism, IAvian, IReptile
{
    public int Age { get; set; }
}