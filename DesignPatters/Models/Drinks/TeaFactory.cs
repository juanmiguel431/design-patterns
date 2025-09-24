namespace DesignPatters.Models.Drinks;

internal class TeaFactory : IHotDrinkFactory
{
    public DrinkType Type => DrinkType.Tea;
    
    public IHotDrink Prepare(int amount)
    {
        Console.WriteLine($"Put in a tea bag, boil water, pour {amount}ml, add lemon and enjoy!");
        return new Tea();
    }
}