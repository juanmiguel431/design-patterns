namespace DesignPatters.Models.Drinks;

internal class CoffeeFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        Console.WriteLine($"Put in a coffee cup, boil water, pour {amount}ml, add sugar and enjoy!");
        return new Coffee();
    }
}