namespace DesignPatters.Models.Points;

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