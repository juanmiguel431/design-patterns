namespace DesignPatters.Models.Drinks;

public interface IHotDrinkFactory
{
    DrinkType Type { get; }
    IHotDrink Prepare(int amount);
}