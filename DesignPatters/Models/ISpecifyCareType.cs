namespace DesignPatters.Models;

public interface ISpecifyCareType
{
    ISpecifyWheelSize OfType(CarType type);
}