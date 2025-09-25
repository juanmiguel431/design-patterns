namespace DesignPatters.Models.Persons;

public interface IPrototype<T>
{
    T DeepCopy();
}

public interface IDeepCopyable<T>
{
    T DeepCopy();
}