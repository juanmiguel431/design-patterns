namespace DesignPatters.Models.Drinks;

public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}