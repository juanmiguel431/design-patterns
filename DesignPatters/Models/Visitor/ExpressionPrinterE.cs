using System.Text;

namespace DesignPatters.Models.Visitor;

public class ExpressionPrinterE : ExpressionVisitorE
{
    private readonly StringBuilder _sb = new();
    
    public override void Visit(ValueE value)
    {
        _sb.Append(value.TheValue);
    }

    public override void Visit(AdditionExpressionE ae)
    {
        var left = ae.LHS;
        var right = ae.RHS;
        
        _sb.Append('(');
        left.Accept(this);
        _sb.Append('+');
        right.Accept(this);
        _sb.Append(')');
    }

    public override void Visit(MultiplicationExpressionE me)
    {
        var left = me.LHS;
        var right = me.RHS;
        
        _sb.Append('(');
        left.Accept(this);
        _sb.Append('*');
        right.Accept(this);
        _sb.Append(')');
    }

    public override string ToString()
    {
        return _sb.ToString();
    }
}