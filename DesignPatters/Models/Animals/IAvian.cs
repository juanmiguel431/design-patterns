namespace DesignPatters.Models.Animals;

public interface IAvian : ICreature
{
    public void Fly()
    {
        if (Age >= 10)
        {
            Console.WriteLine("I am flying!");
        }
    }
}