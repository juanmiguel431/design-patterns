namespace DesignPatters.Models.Visitor;

public interface IExpressionVisitor
{
    void Visit(DoubleExpression expression);
    void Visit(AdditionExpression expression);
}