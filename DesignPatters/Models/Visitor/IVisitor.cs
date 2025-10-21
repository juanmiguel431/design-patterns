namespace DesignPatters.Models.Visitor;

public interface IVisitor<TVisitable>
{
    void Visit(TVisitable obj);
}

public interface IVisitor
{
}

public interface IVisitor<T, TResult>
{
    TResult Visit(IVisitor<T, TResult> visitor, T node);
    TResult Visit(T node);
}