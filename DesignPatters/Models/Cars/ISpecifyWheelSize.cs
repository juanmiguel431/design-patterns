namespace DesignPatters.Models.Cars;

public interface ISpecifyWheelSize
{
    IBuildCar WheelSize(int size);
}