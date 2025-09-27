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

    public Wall(Point start, Point end, int height)
    {
        Start = start;
        End = end;
        Height = height;
    }
}