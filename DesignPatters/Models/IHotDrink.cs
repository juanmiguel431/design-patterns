namespace DesignPatters.Models;

public interface IHotDrink
{
    void Consume();
}

internal class Tea : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("This tea is nice but I would prefer it with milk.");
    }
}

internal class Coffee : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("This coffee is sensational.");
    }
}

public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}

internal class TeaFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        Console.WriteLine($"Put in a tea bag, boil water, pour {amount}ml, add lemon and enjoy!");
        return new Tea();
    }
}

internal class CoffeeFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        Console.WriteLine($"Put in a coffee cup, boil water, pour {amount}ml, add sugar and enjoy!");
        return new Coffee();
    }
}

public class HotDrinkMachine
{
    public enum AvailableDrinks
    {
        Tea,
        Coffee
    }

    private Dictionary<AvailableDrinks, IHotDrinkFactory> _factories = new();

    public HotDrinkMachine()
    {
        foreach (var drink in Enum.GetValues<AvailableDrinks>())
        {
            var factory = (IHotDrinkFactory)Activator.CreateInstance(
                Type.GetType("DesignPatters.Models." + Enum.GetName(typeof(AvailableDrinks), drink) + "Factory")
            );

            _factories.Add(drink, factory);
        }
    }

    public IHotDrink MakeDrink(AvailableDrinks drink, int amount)
    {
        return _factories[drink].Prepare(amount);
    }
}