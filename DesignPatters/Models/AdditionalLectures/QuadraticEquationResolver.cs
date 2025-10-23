using System.Numerics;

namespace DesignPatters.Models.AdditionalLectures;

public enum WorkflowResult
{
    Success,
    Failure,
}

public class QuadraticEquationResolver
{
    // ax^2 + bx + c = 0
    public WorkflowResult Start(double a, double b, double c, out ValueTuple<Complex, Complex>? result)
    {
        var discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            result = null;
            return WorkflowResult.Failure;
            // return SolveComplex(a, b, c, discriminant);
        }
        
        return SolveSimple(a, b, discriminant, out result);
    }

    private WorkflowResult SolveSimple(double a, double b, double discriminant, out (Complex, Complex)? result)
    {
        var rootDiscriminant = Math.Sqrt(discriminant);
        var root1 = (-b + rootDiscriminant) / (2 * a);
        var root2 = (-b - rootDiscriminant) / (2 * a);
        
        result = (root1, root2);
        return WorkflowResult.Success;
    }

    private ValueTuple<Complex, Complex> SolveComplex(double a, double b, double discriminant)
    {
        var rootDiscriminant = Complex.Sqrt(new Complex(discriminant, 0));
        var root1 = (-b + rootDiscriminant) / (2 * a);
        var root2 = (-b - rootDiscriminant) / (2 * a);
        
        return (root1, root2);
    }
}