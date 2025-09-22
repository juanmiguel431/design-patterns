namespace DesignPatters.Models;

public interface ISpecifyWheelSize
{
    IBuildCar WheelSize(int size);
}