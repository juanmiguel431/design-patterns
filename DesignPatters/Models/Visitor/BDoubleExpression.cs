namespace DesignPatters.Models.Visitor;

public class BDoubleExpression : BExpression
{
    public double Value { get; }
    
    public BDoubleExpression(double value)
    {
        Value = value;
    }
}