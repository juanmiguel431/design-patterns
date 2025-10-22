namespace DesignPatters.Models.Visitor;

public class AdditionExpressionE : ExpressionE
{
    public readonly ExpressionE LHS, RHS;

    public AdditionExpressionE(ExpressionE lhs, ExpressionE rhs)
    {
        LHS = lhs;
        RHS = rhs;
    }
    
    public override void Accept(ExpressionVisitorE ev)
    {
        ev.Visit(this);
    }
}