using System.Runtime.Serialization;
using System.Text;

namespace DesignPatters.Models;

public class CodeGenerator
{
    private StringBuilder _stringBuilder = new();

    public override string ToString()
    {
        return _stringBuilder.ToString();
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        ((ISerializable)_stringBuilder).GetObjectData(info, context);
    }

    public CodeGenerator Append(bool value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(byte value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(char value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public unsafe CodeGenerator Append(char* value, int valueCount)
    {
        _stringBuilder.Append(value, valueCount);
        return this;
    }

    public CodeGenerator Append(char value, int repeatCount)
    {
        _stringBuilder.Append(value, repeatCount);
        return this;
    }

    public CodeGenerator Append(char[]? value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(char[]? value, int startIndex, int charCount)
    {
        _stringBuilder.Append(value, startIndex, charCount);
        return this;
    }

    public CodeGenerator Append(decimal value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(double value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(IFormatProvider? provider, ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        _stringBuilder.Append(provider, ref handler);
        return this;
    }

    public CodeGenerator Append(short value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(int value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(long value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(object? value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(ReadOnlyMemory<char> value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(ReadOnlySpan<char> value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(sbyte value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(float value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(string? value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(string? value, int startIndex, int count)
    {
        _stringBuilder.Append(value, startIndex, count);
        return this;
    }

    public CodeGenerator Append(StringBuilder? value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(StringBuilder? value, int startIndex, int count)
    {
        _stringBuilder.Append(value, startIndex, count);
        return this;
    }

    public CodeGenerator Append(ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        _stringBuilder.Append(ref handler);
        return this;
    }

    public CodeGenerator Append(ushort value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(uint value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator Append(ulong value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CodeGenerator AppendFormat(IFormatProvider? provider, string format, object? arg0)
    {
        _stringBuilder.AppendFormat(provider, format, arg0);
        return this;
    }

    public CodeGenerator AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1)
    {
        _stringBuilder.AppendFormat(provider, format, arg0, arg1);
        return this;
    }

    public CodeGenerator AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1,
        object? arg2)
    {
        _stringBuilder.AppendFormat(provider, format, arg0, arg1, arg2);
        return this;
    }

    public CodeGenerator AppendFormat(IFormatProvider? provider, string format, params object?[] args)
    {
        _stringBuilder.AppendFormat(provider, format, args);
        return this;
    }

    public CodeGenerator AppendFormat(IFormatProvider? provider, string format, params ReadOnlySpan<object?> args)
    {
        _stringBuilder.AppendFormat(provider, format, args);
        return this;
    }

    public CodeGenerator AppendFormat(IFormatProvider? provider, CompositeFormat format, params object?[] args)
    {
        _stringBuilder.AppendFormat(provider, format, args);
        return this;
    }

    public CodeGenerator AppendFormat(IFormatProvider? provider, CompositeFormat format,
        params ReadOnlySpan<object?> args)
    {
        _stringBuilder.AppendFormat(provider, format, args);
        return this;
    }

    public CodeGenerator AppendFormat(string format, object? arg0)
    {
        _stringBuilder.AppendFormat(format, arg0);
        return this;
    }

    public CodeGenerator AppendFormat(string format, object? arg0, object? arg1)
    {
        _stringBuilder.AppendFormat(format, arg0, arg1);
        return this;
    }

    public CodeGenerator AppendFormat(string format, object? arg0, object? arg1, object? arg2)
    {
        _stringBuilder.AppendFormat(format, arg0, arg1, arg2);
        return this;
    }

    public CodeGenerator AppendFormat(string format, params object?[] args)
    {
        _stringBuilder.AppendFormat(format, args);
        return this;
    }

    public CodeGenerator AppendFormat(string format, params ReadOnlySpan<object?> args)
    {
        _stringBuilder.AppendFormat(format, args);
        return this;
    }

    public CodeGenerator AppendFormat<TArg0>(IFormatProvider? provider, CompositeFormat format, TArg0 arg0)
    {
        _stringBuilder.AppendFormat(provider, format, arg0);
        return this;
    }

    public CodeGenerator AppendFormat<TArg0, TArg1>(IFormatProvider? provider, CompositeFormat format, TArg0 arg0,
        TArg1 arg1)
    {
        _stringBuilder.AppendFormat(provider, format, arg0, arg1);
        return this;
    }

    public CodeGenerator AppendFormat<TArg0, TArg1, TArg2>(IFormatProvider? provider, CompositeFormat format,
        TArg0 arg0,
        TArg1 arg1, TArg2 arg2)
    {
        _stringBuilder.AppendFormat(provider, format, arg0, arg1, arg2);
        return this;
    }

    public CodeGenerator AppendJoin(char separator, params object?[] values)
    {
        _stringBuilder.AppendJoin(separator, values);
        return this;
    }

    public CodeGenerator AppendJoin(char separator, params string?[] values)
    {
        _stringBuilder.AppendJoin(separator, values);
        return this;
    }

    public CodeGenerator AppendJoin(char separator, params ReadOnlySpan<object?> values)
    {
        _stringBuilder.AppendJoin(separator, values);
        return this;
    }

    public CodeGenerator AppendJoin(char separator, params ReadOnlySpan<string?> values)
    {
        _stringBuilder.AppendJoin(separator, values);
        return this;
    }

    public CodeGenerator AppendJoin(string? separator, params object?[] values)
    {
        _stringBuilder.AppendJoin(separator, values);
        return this;
    }

    public CodeGenerator AppendJoin(string? separator, params string?[] values)
    {
        _stringBuilder.AppendJoin(separator, values);
        return this;
    }

    public CodeGenerator AppendJoin(string? separator, params ReadOnlySpan<object?> values)
    {
        _stringBuilder.AppendJoin(separator, values);
        return this;
    }

    public CodeGenerator AppendJoin(string? separator, params ReadOnlySpan<string?> values)
    {
        _stringBuilder.AppendJoin(separator, values);
        return this;
    }

    public CodeGenerator AppendJoin<T>(char separator, IEnumerable<T> values)
    {
        _stringBuilder.AppendJoin(separator, values);
        return this;
    }

    public CodeGenerator AppendJoin<T>(string? separator, IEnumerable<T> values)
    {
        _stringBuilder.AppendJoin(separator, values);
        return this;
    }

    public CodeGenerator AppendLine()
    {
        _stringBuilder.AppendLine();
        return this;
    }

    public CodeGenerator AppendLine(IFormatProvider? provider,
        ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        _stringBuilder.AppendLine(provider, ref handler);
        return this;
    }

    public CodeGenerator AppendLine(string? value)
    {
        _stringBuilder.AppendLine(value);
        return this;
    }

    public CodeGenerator AppendLine(ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        _stringBuilder.AppendLine(ref handler);
        return this;
    }

    public CodeGenerator Clear()
    {
        _stringBuilder.Clear();
        return this;
    }

    public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
    {
        _stringBuilder.CopyTo(sourceIndex, destination, destinationIndex, count);
    }

    public void CopyTo(int sourceIndex, Span<char> destination, int count)
    {
        _stringBuilder.CopyTo(sourceIndex, destination, count);
    }

    public int EnsureCapacity(int capacity)
    {
        return _stringBuilder.EnsureCapacity(capacity);
    }

    public bool Equals(ReadOnlySpan<char> span)
    {
        return _stringBuilder.Equals(span);
    }

    public bool Equals(StringBuilder? sb)
    {
        return _stringBuilder.Equals(sb);
    }

    public StringBuilder.ChunkEnumerator GetChunks()
    {
        return _stringBuilder.GetChunks();
    }

    public CodeGenerator Insert(int index, bool value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, byte value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, char value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, char[]? value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, char[]? value, int startIndex, int charCount)
    {
        _stringBuilder.Insert(index, value, startIndex, charCount);
        return this;
    }

    public CodeGenerator Insert(int index, decimal value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, double value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, short value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, int value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, long value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, object? value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, ReadOnlySpan<char> value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, sbyte value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, float value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, string? value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, string? value, int count)
    {
        _stringBuilder.Insert(index, value, count);
        return this;
    }

    public CodeGenerator Insert(int index, ushort value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, uint value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Insert(int index, ulong value)
    {
        _stringBuilder.Insert(index, value);
        return this;
    }

    public CodeGenerator Remove(int startIndex, int length)
    {
        _stringBuilder.Remove(startIndex, length);
        return this;
    }

    public CodeGenerator Replace(char oldChar, char newChar)
    {
        _stringBuilder.Replace(oldChar, newChar);
        return this;
    }

    public CodeGenerator Replace(char oldChar, char newChar, int startIndex, int count)
    {
        _stringBuilder.Replace(oldChar, newChar, startIndex, count);
        return this;
    }

    public CodeGenerator Replace(ReadOnlySpan<char> oldValue, ReadOnlySpan<char> newValue)
    {
        _stringBuilder.Replace(oldValue, newValue);
        return this;
    }

    public CodeGenerator Replace(ReadOnlySpan<char> oldValue, ReadOnlySpan<char> newValue, int startIndex, int count)
    {
        _stringBuilder.Replace(oldValue, newValue, startIndex, count);
        return this;
    }

    public CodeGenerator Replace(string oldValue, string? newValue)
    {
        _stringBuilder.Replace(oldValue, newValue);
        return this;
    }

    public CodeGenerator Replace(string oldValue, string? newValue, int startIndex, int count)
    {
        _stringBuilder.Replace(oldValue, newValue, startIndex, count);
        return this;
    }

    public string ToString(int startIndex, int length)
    {
        return _stringBuilder.ToString(startIndex, length);
    }

    public int Capacity
    {
        get => _stringBuilder.Capacity;
        set => _stringBuilder.Capacity = value;
    }

    public char this[int index]
    {
        get => _stringBuilder[index];
        set => _stringBuilder[index] = value;
    }

    public int Length
    {
        get => _stringBuilder.Length;
        set => _stringBuilder.Length = value;
    }

    public int MaxCapacity => _stringBuilder.MaxCapacity;
}