namespace DesignPatters.Models;

public class Car
{
    public CarType Type { get; set; }
    public int WheelSize { get; set; }

    public override string ToString()
    {
        return $"{{" +
               $" {nameof(Type)}: {Type}," +
               $" {nameof(WheelSize)}: {WheelSize}" +
               $"}}";
    }
}