namespace DesignPatters.Models;

public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public override string ToString()
    {
        return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
}