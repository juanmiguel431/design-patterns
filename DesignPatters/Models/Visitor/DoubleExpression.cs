using System.Text;

namespace DesignPatters.Models.Visitor;

public class DoubleExpression : Expression
{
    private readonly double _value;
    public double Value => _value;

    public DoubleExpression(double value)
    {
        _value = value;
    }

    public override void Print(StringBuilder sb)
    {
        sb.Append(_value);
    }
}