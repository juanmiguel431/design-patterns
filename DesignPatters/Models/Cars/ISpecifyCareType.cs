namespace DesignPatters.Models.Cars;

public interface ISpecifyCareType
{
    ISpecifyWheelSize OfType(CarType type);
}