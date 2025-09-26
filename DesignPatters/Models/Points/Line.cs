using DesignPatters.Models.Persons;

namespace DesignPatters.Models.Points;

public class Line : IPrototype<Line>
{
    public Point Start, End;

    public Line()
    {
    }
    
    public Line(Line other)
    {
        Start = new Point(other.Start);
        End = new Point(other.End);
    }

    public Line DeepCopy()
    {
        return new Line(this);
    }
    
    public override string ToString()
    {
        return $"{nameof(Start)}: {Start}, {nameof(End)}: {End}";
    }
}