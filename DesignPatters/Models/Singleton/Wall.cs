using DesignPatters.Models.Points;

namespace DesignPatters.Models.Singleton;

public class Wall
{
    public Point Start { get; set; }
    public Point End { get; set; }
    public int Height { get; set; }

    public Wall()
    {
    }

    public Wall(Point start, Point end)
    {
        Start = start;
        End = end;
        Height = BuildingContext.Current.WallHeight;
    }

    public override string ToString()
    {
        return $"{nameof(Start)}: {Start}, {nameof(End)}: {End}, {nameof(Height)}: {Height}";
    }
}