namespace DesignPatters.Models.Visitor;

public class SquareTransformer : ITransformer<Expression>
{
    public Expression Transform(DoubleExpression e)
    {
        return new DoubleExpression(e.Value * e.Value);
    }

    public Expression Transform(AdditionExpression e)
    {
        return new AdditionExpression(e.Left.Reduce(this), e.Right.Reduce(this));
    }
}