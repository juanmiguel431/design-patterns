namespace DesignPatters.Models;

public class Point
{
    private readonly double _x;
    private readonly double _y;
    private readonly CoordinateSystem _coordinateSystem;

    /// <summary>
    /// Initialize a point from either cartesian or polar coordinates.
    /// </summary>
    /// <param name="a">x if cartesian, rho if polar</param>
    /// <param name="b">y if cartesian, theta if polar</param>
    /// <param name="coordinateSystem"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Point(double a, double b, CoordinateSystem coordinateSystem = CoordinateSystem.Cartesian)
    {
        switch (coordinateSystem)
        {
            case CoordinateSystem.Cartesian:
                _x = a;
                _y = b;
                break;
            case CoordinateSystem.Polar:
                _x = a * Math.Cos(b);
                _y = a * Math.Sin(b);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(coordinateSystem), coordinateSystem, null);
        }
        
        _coordinateSystem = coordinateSystem;
    }
}

public enum CoordinateSystem
{
    Cartesian, Polar
}