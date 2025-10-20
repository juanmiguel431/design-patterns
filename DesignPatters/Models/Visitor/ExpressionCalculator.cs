namespace DesignPatters.Models.Visitor;

public class ExpressionCalculator : IExpressionVisitor
{
    private double _result;
    public double Result => _result;
    
    public void Visit(DoubleExpression expression)
    {
        _result = expression.Value;
    }

    public void Visit(AdditionExpression expression)
    {
        expression.Left.Accept(this);
        var a = _result;
        
        expression.Right.Accept(this);
        var b = _result;
        
        _result = a + b;
    }
}