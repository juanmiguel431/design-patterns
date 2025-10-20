namespace DesignPatters.Models.Visitor;

public class EvaluationTransformer : ITransformer<double>
{
    public double Transform(DoubleExpression e)
    {
        return e.Value;
    }

    public double Transform(AdditionExpression e)
    {
        return e.Left.Reduce(this) + e.Right.Reduce(this);
    }
}