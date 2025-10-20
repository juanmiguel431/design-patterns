using System.Text;

namespace DesignPatters.Models.Visitor;

public static class ExpressionPrinter
{
    private static readonly Dictionary<Type, Action<Expression, StringBuilder>> Actions = new()
    {
        [typeof(DoubleExpression)] = (e, sb) =>
        {
            var de = (DoubleExpression)e;
            sb.Append(de.Value);
        },
        [typeof(AdditionExpression)] = (e, sb) =>
        {
            var additionExpression = (AdditionExpression)e;
            
            sb.Append('(');
            additionExpression.Left.PrintFromExtensionV2(sb);
            sb.Append('+');
            additionExpression.Right.PrintFromExtensionV2(sb);
            sb.Append(')');
        }
    };

    public static void PrintFromExtensionV2(this Expression e, StringBuilder sb)
    {
        Actions[e.GetType()](e, sb);
    }
    
    public static void PrintFromExtension(this Expression e, StringBuilder sb)
    {
        if (e is DoubleExpression de)
        {
            sb.Append(de.Value);
        }
        else if (e is AdditionExpression ae)
        {
            sb.Append('(');
            ae.Left.Print(sb);
            sb.Append('+');
            ae.Right.Print(sb);
            sb.Append(')');
        }
    }
}