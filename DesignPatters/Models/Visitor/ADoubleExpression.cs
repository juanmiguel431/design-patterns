namespace DesignPatters.Models.Visitor;

public class ADoubleExpression : AExpression
{
    public double Value { get; }

    public ADoubleExpression(double value)
    {
        Value = value;
    }

    public override void Accept(IVisitor visitor)
    {
        if (visitor is IVisitor<ADoubleExpression> typed)
        {
            typed.Visit(this);
        }
    }
}