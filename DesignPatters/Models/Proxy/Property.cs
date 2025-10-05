namespace DesignPatters.Models.Proxy;

public class Property<T> : IEquatable<Property<T>> where T : new()
{
    private T _value;
    public T Value
    {
        get => _value;
        set
        {
            if (Equals(_value, value)) return;
            Console.WriteLine($"Assigning value to {value}");
            _value = value;
        }
    }

    public Property(T value)
    {
        _value = value;
    }

    public Property() : this(new T())
    {
    }
    
    public static implicit operator T(Property<T> property)
    {
        return property.Value;
    }

    public static implicit operator Property<T>(T value)
    {
        return new Property<T>(value);
    }

    public bool Equals(Property<T>? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return EqualityComparer<T>.Default.Equals(_value, other._value);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Property<T>)obj);
    }

    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }

    public static bool operator ==(Property<T>? left, Property<T>? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Property<T>? left, Property<T>? right)
    {
        return !Equals(left, right);
    }
}