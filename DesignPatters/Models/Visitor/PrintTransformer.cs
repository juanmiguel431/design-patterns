namespace DesignPatters.Models.Visitor;

public class PrintTransformer : ITransformer<string>
{
    public string Transform(DoubleExpression e)
    {
        return e.Value.ToString();
    }

    public string Transform(AdditionExpression e)
    {
        return $"({e.Left.Reduce(this)}+{e.Right.Reduce(this)})";
    }
}