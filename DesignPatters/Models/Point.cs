namespace DesignPatters.Models;

public class Point
{
    private readonly double _x;
    private readonly double _y;

    public Point(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public override string ToString()
    {
        return $"{nameof(_x)}: {_x}, {nameof(_y)}: {_y}";
    }

    // Factory Method
    public static Point CreateNewCartesianPoint(double x, double y)
    {
        return new Point(x, y);
    }
    
    public static Point CreateNewPolarPoint(double rho, double theta)
    {
        return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
    }
}

public enum CoordinateSystem
{
    Cartesian, Polar
}

public class PointFactory
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