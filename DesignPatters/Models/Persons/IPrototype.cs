namespace DesignPatters.Models.Persons;

public interface IPrototype<T>
{
    T DeepCopy();
}

public interface IDeepCopyable<T>
    where T : new()
{
    void CopyTo(T target);

    T DeepClone()
    {
        var target = new T();
        CopyTo(target);
        return target;
    }
}