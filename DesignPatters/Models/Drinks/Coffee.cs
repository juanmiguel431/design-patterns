namespace DesignPatters.Models.Drinks;

internal class Coffee : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("This coffee is sensational.");
    }
}