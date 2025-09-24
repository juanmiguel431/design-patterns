namespace DesignPatters.Models.Drinks;

public class HotDrinkMachine
{
    private readonly Dictionary<DrinkType, IHotDrinkFactory> _factories = new();
    
    public HotDrinkMachine()
    {
        var types = typeof(HotDrinkMachine).Assembly.GetTypes();
        Console.WriteLine("Available drinks:");
        foreach (var t in types)
        {
            if (!typeof(IHotDrinkFactory).IsAssignableFrom(t) || t.IsInterface) continue;
            
            var instance = (IHotDrinkFactory)Activator.CreateInstance(t)!;
            Console.WriteLine(instance.Type);
            _factories.Add(instance.Type, instance);
        }
    }

    public IHotDrink MakeDrink(DrinkType type, int amount)
    {
        return _factories[type].Prepare(amount);
    }
}