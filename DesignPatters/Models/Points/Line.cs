using DesignPatters.Models.Persons;

namespace DesignPatters.Models.Points;

public class Line : IPrototype<Line>
{
    public Point Start { get; set;}
    public Point End { get; set; }

    public Line()
    {
    }
    
    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
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

    protected bool Equals(Line other)
    {
        return Start.Equals(other.Start) && End.Equals(other.End);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Line)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Start, End);
    }
}