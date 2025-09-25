namespace DesignPatters.Models.Persons;

public interface IPrototype<T>
{
    T DeepCopy();
}