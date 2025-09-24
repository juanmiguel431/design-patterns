namespace DesignPatters.Models.Drinks;

internal class Tea : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("This tea is nice but I would prefer it with milk.");
    }
}