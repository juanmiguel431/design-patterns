using System.Text;

namespace DesignPatters.Models.Visitor;

public class ExpressionPrinterVisitor : IExpressionVisitor
{
    private readonly StringBuilder _sb = new();
    
    public void Visit(DoubleExpression expression)
    {
        _sb.Append(expression.Value);
    }

    public void Visit(AdditionExpression expression)
    {
        _sb.Append('(');
        expression.Left.Accept(this);
        _sb.Append('+');
        expression.Right.Accept(this);
        _sb.Append(')');
    }
    
    public override string ToString()
    {
        return _sb.ToString();
    }
}