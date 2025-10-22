namespace DesignPatters.Models.Visitor;

public class MultiplicationExpressionE : ExpressionE
{
    public readonly ExpressionE LHS, RHS;

    public MultiplicationExpressionE(ExpressionE lhs, ExpressionE rhs)
    {
        LHS = lhs;
        RHS = rhs;
    }
    
    public override void Accept(ExpressionVisitorE ev)
    {
        ev.Visit(this);
    }
}