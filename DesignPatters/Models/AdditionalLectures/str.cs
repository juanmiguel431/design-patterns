using System.Text;
using JetBrains.Annotations;

namespace DesignPatters.Models.AdditionalLectures;

// ascii utf-16
public class str : IEquatable<str>, IEquatable<string>
{
    [NotNull] private readonly byte[] _buffer;

    public str()
    {
        _buffer = new byte[]{};
    }

    public str(string str)
    {
        _buffer = Encoding.ASCII.GetBytes(str);
    }

    protected str(byte[] buffer)
    {
        _buffer = buffer;
    }
    
    public override string ToString()
    {
        return Encoding.ASCII.GetString(_buffer);
    }

    public static implicit operator str(string str)
    {
        return new str(str);
    }

    public bool Equals(str? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return _buffer.Equals(other._buffer);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((str)obj);
    }
    
    public bool Equals(string? other)
    {
        return ToString() == other;
    }

    public override int GetHashCode()
    {
        return _buffer.GetHashCode();
    }

    public static bool operator ==(str? left, str? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(str? left, str? right)
    {
        return !Equals(left, right);
    }
    
    //str + str
    public static str operator +(str first, str second)
    {
        var bytes = new byte[first._buffer.Length + second._buffer.Length];
        
        first._buffer.CopyTo(bytes, 0);
        second._buffer.CopyTo(bytes, first._buffer.Length);
        
        return new str(bytes);
    }
    
    public char this[int index]
    {
        get => (char)_buffer[index];
        set => _buffer[index] = (byte)value;
    }
}