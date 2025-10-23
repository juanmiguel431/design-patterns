using System.Numerics;

namespace DesignPatters.Models.AdditionalLectures;

public class QuadraticEquationResolver
{
    // ax^2 + bx + c = 0
    public ValueTuple<Complex, Complex> Start(double a, double b, double c)
    {
        var discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            return SolveComplex(a, b, c, discriminant);
        }
        return SolveSimple(a, b, c, discriminant);
    }

    private (Complex, Complex) SolveSimple(double a, double b, double c, double discriminant)
    {
        var rootDiscriminant = Math.Sqrt(discriminant);
        var root1 = (-b + rootDiscriminant) / (2 * a);
        var root2 = (-b - rootDiscriminant) / (2 * a);
        
        return (root1, root2);
    }

    private ValueTuple<Complex, Complex> SolveComplex(double a, double b, double c, double discriminant)
    {
        var rootDiscriminant = Complex.Sqrt(new Complex(discriminant, 0));
        var root1 = (-b + rootDiscriminant) / (2 * a);
        var root2 = (-b - rootDiscriminant) / (2 * a);
        
        return (root1, root2);
    }
}