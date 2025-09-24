namespace DesignPatters.Models.Cars;

public class Car
{
    public CarType Type { get; set; }
    public int WheelSize { get; set; }

    public static ISpecifyCareType Builder() => CarBuilder.Create();

    public override string ToString()
    {
        return $"{{" +
               $" {nameof(Type)}: {Type}," +
               $" {nameof(WheelSize)}: {WheelSize}" +
               $"}}";
    }
}