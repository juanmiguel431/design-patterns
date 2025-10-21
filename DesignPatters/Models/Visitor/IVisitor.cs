namespace DesignPatters.Models.Visitor;

public interface IVisitor<TVisitable>
{
    void Visit(TVisitable obj);
}

public interface IVisitor { }