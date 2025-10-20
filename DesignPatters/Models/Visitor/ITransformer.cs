namespace DesignPatters.Models.Visitor;

public interface ITransformer<out T>
{
    T Transform(DoubleExpression e);
    T Transform(AdditionExpression e);
}