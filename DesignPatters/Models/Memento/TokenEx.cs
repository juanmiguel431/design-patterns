namespace DesignPatters.Models.Memento;

public class TokenEx
{
    public int Value { get; }

    public TokenEx(int value)
    {
        Value = value;
    }

    public TokenEx(TokenEx other)
    {
        Value = other.Value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}