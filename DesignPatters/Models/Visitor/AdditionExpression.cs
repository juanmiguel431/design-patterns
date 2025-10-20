using System.Text;

namespace DesignPatters.Models.Visitor;

public class AdditionExpression : Expression
{
    private readonly Expression _left;
    private readonly Expression _right;

    public Expression Left => _left;
    public Expression Right => _right;

    public AdditionExpression(Expression left, Expression right)
    {
        _left = left ?? throw new ArgumentNullException(nameof(left));
        _right = right ?? throw new ArgumentNullException(nameof(right));
    }

    public override void Print(StringBuilder sb)
    {
        sb.Append('(');
        _left.Print(sb);
        sb.Append('+');
        _right.Print(sb);
        sb.Append(')');
    }

    public override void Accept(IExpressionVisitor visitor)
    {
        visitor.Visit(this);
    }

    public override T Reduce<T>(ITransformer<T> transformer)
    {
        return transformer.Transform(this);
    }
}