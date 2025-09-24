namespace DesignPatters.Models.Drinks;

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