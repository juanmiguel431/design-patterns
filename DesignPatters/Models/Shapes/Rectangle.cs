namespace DesignPatters.Models.Shapes;

public class Rectangle : Shape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public override string ToString()
    {
        return $"Rectangle: {nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }

    public override int GetArea()
    {
        return Width * Height;
    }
}