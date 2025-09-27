using System.Collections;

namespace DesignPatters.Models.Points;

public class LineToPointAdapter : IEnumerable<Point>
{
    private static int _count;
    private static readonly Dictionary<int, List<Point>> Cache = new();
    private readonly int _hashCode;

    public LineToPointAdapter(Line line)
    {
        _hashCode = line.GetHashCode();
        if (Cache.ContainsKey(_hashCode)) return;
        
        Console.WriteLine($"{++_count}: Generating points for line [{line.Start.X},{line.Start.Y}]-[{line.End.X},{line.End.Y}]");
        
        var points = new List<Point>();
        
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
                points.Add(Point.Factory.CreateNewCartesianPoint(left, y));
            }
        }
        else if (dy == 0)
        {
            for (var x = left; x <= right; x++)
            {
                points.Add(Point.Factory.CreateNewCartesianPoint(x, top));
            }
        }
        
        Cache.Add(_hashCode, points);
    }

    public IEnumerator<Point> GetEnumerator()
    {
        return Cache[_hashCode].GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}