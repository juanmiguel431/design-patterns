using System.Text;

namespace DesignPatters.Models.Visitor;

public abstract class Expression
{
    public abstract void Print(StringBuilder sb);
    public abstract void Accept(IExpressionVisitor visitor);
    public abstract T Reduce<T>(ITransformer<T> transformer);
}