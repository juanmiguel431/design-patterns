namespace DesignPatters.Models.Visitor;

public abstract class AExpression 
{
    public virtual void Accept(IVisitor visitor)
    {
        if (visitor is IVisitor<AExpression> typed)
        {
            typed.Visit(this);
        }
    }
}