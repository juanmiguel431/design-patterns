namespace DesignPatters.Models.Visitor;

public class AExpressionPrinter : IVisitor,
    IVisitor<AExpression>,
    IVisitor<ADoubleExpression>,
    IVisitor<AAdditionExpression>
{
    private readonly MyStringBuilder _sb = new();
    
    public void Visit(AExpression obj) { }

    public void Visit(ADoubleExpression obj)
    {
        _sb.Append(obj.Value);
    }

    public void Visit(AAdditionExpression obj)
    {
        _sb.Append('(');
        obj.Left.Accept(this);
        _sb.Append('+');
        obj.Right.Accept(this);
        _sb.Append(')');
    }
    
    public override string ToString() => _sb.ToString();
}