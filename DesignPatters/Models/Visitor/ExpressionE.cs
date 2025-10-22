namespace DesignPatters.Models.Visitor;

public abstract class ExpressionE
{
    public abstract void Accept(ExpressionVisitorE ev);
}