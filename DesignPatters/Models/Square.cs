namespace DesignPatters.Models;

public class Square : Shape
{
    public int Side { get; set; }

    public override int GetArea()
    {
        return Side * Side;
    }

    public override string ToString()
    {
        return $"Square: {nameof(Side)}: {Side}";
    }
}