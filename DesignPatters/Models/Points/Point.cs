using DesignPatters.Models.Persons;

namespace DesignPatters.Models.Points;

public class Point : IPrototype<Point>
{
    private readonly double _x;
    private readonly double _y;
    
    public double X => _x;
    public double Y => _y;

    public static readonly Point Origin = new (0, 0);
    // public static Point Origin2 => new(0, 0);

    private Point(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public Point(Point other)
    {
        _x = other._x;
        _y = other._y;
    }

    public Point DeepCopy()
    {
        return new Point(this);
    }

    public override string ToString()
    {
        return $"{nameof(_x)}: {_x}, {nameof(_y)}: {_y}";
    }
    
    public static class Factory
    {
        public static Point CreateNewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }
    
        public static Point CreateNewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
    }
}