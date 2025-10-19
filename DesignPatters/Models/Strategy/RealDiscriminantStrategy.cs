namespace DesignPatters.Models.Strategy;

public class RealDiscriminantStrategy : IDiscriminantStrategy
{
    /// <summary>
    /// return NaN on negative discriminant!
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public double CalculateDiscriminant(double a, double b, double c)
    {
        var discriminant = (b * b) - (4 * a * c);
        return discriminant < 0 ? double.NaN : discriminant;
    }
}