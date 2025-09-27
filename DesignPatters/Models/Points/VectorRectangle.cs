namespace DesignPatters.Models.Points;

public class VectorRectangle : VectorObject
{
    public VectorRectangle(int x, int y, int width, int height)
    {
        Add(new Line(Point.Factory.CreateNewCartesianPoint(x, y), Point.Factory.CreateNewCartesianPoint(x + width, y)));
        Add(new Line(Point.Factory.CreateNewCartesianPoint(x + width, y), Point.Factory.CreateNewCartesianPoint(x + width, y + height)));
        Add(new Line(Point.Factory.CreateNewCartesianPoint(x, y), Point.Factory.CreateNewCartesianPoint(x, y + height)));
        Add(new Line(Point.Factory.CreateNewCartesianPoint(x, y + height), Point.Factory.CreateNewCartesianPoint(x + width, y + height)));
    }
}