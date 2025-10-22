namespace DesignPatters.Models.Visitor;

public class ValueE : ExpressionE
{
    public readonly int TheValue;

    public ValueE(int value)
    {
        TheValue = value;
    }
    
    public override void Accept(ExpressionVisitorE ev)
    {
        ev.Visit(this);
    }
}