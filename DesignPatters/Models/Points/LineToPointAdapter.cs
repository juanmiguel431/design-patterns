using System.Collections.ObjectModel;

namespace DesignPatters.Models.Points;

public class LineToPointAdapter : Collection<Point>
{
    private static int _count;

    public LineToPointAdapter(Line line)
    {
        Console.WriteLine($"{++_count}: Generating points for line [{line.Start.X},{line.Start.Y}]-[{line.End.X},{line.End.Y}]");
        
        var left = Math.Min(line.Start.X, line.End.X);
        var right = Math.Max(line.Start.X, line.End.X);
        var top = Math.Min(line.Start.Y, line.End.Y);
        var bottom = Math.Max(line.Start.Y, line.End.Y);
        
        var dx = right - left;
        var dy = line.End.Y - line.Start.Y;

        if (dx == 0)
        {
            for (var y = top; y <= bottom; y++)
            {
                Add(Point.Factory.CreateNewCartesianPoint(left, y));
            }
        }
        else if (dy == 0)
        {
            for (var x = left; x <= right; x++)
            {
                Add(Point.Factory.CreateNewCartesianPoint(x, top));
            }
        }
    }
}