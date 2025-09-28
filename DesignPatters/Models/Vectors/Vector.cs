
namespace DesignPatters.Models.Vectors;

public class Vector<TSelf, T, D>
    where D : IInteger, new ()
    where TSelf : Vector<TSelf, T, D>, new()
{
    protected T[] _data;
    
    public Vector()
    {
        _data = new T[new D().Value];
    }

    public Vector(params T[] values)
    {
        var requiredSize = new D().Value;
        _data = new T[requiredSize];
        
        var providedSized = values.Length;
        if (providedSized > requiredSize)
        {
            throw new ArgumentException("Provided values are too big");
        }
        
        var min = Math.Min(requiredSize, providedSized);
        for (var i = 0; i < min; i++)
        {
            _data[i] = values[i];
        }
    }

    public static TSelf Create(params T[] values)
    {
        var result = new TSelf();
        
        var requiredSize = new D().Value;
        result._data = new T[requiredSize];
        
        var providedSized = values.Length;
        if (providedSized > requiredSize)
        {
            throw new ArgumentException("Provided values are too big");
        }
        
        var min = Math.Min(requiredSize, providedSized);
        for (var i = 0; i < min; i++)
        {
            result._data[i] = values[i];
        }

        return result;
    }

    public T this[int index]
    {
        get => _data[index];
        set => _data[index] = value;
    }
}