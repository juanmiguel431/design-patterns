using System.Text;

namespace DesignPatters.Models.Visitor;

public class DynamicExpressionPrinter
{
    public void Print(AdditionExpression e, StringBuilder sb)
    {
        sb.Append('(');
        Print((dynamic)e.Left, sb);
        
        sb.Append('+');
        Print((dynamic)e.Right, sb);
        sb.Append(')');
    }
    
    public void Print(DoubleExpression e, StringBuilder sb)
    {
        sb.Append(e.Value);
    }
}