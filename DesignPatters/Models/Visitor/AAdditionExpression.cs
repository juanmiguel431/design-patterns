namespace DesignPatters.Models.Visitor;

public class AAdditionExpression : AExpression
{
    public AExpression Left { get; }

    public AExpression Right { get; }

    public AAdditionExpression(AExpression left, AExpression right)
    {
        Left = left ?? throw new ArgumentNullException(nameof(left));
        Right = right ?? throw new ArgumentNullException(nameof(right));
    }
    
    public override void Accept(IVisitor visitor)
    {
        if (visitor is IVisitor<AAdditionExpression> typed)
        {
            typed.Visit(this);
        }
    }
}