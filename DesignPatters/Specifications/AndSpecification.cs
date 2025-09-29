namespace DesignPatters.Specifications;

// combinator
public class AndSpecification<T> : Specification<T>
{
    private readonly ISpecification<T> _left, _right;

    public AndSpecification(ISpecification<T> left, ISpecification<T> right)
    {
        _left = left;
        _right = right;
    }
    
    public override bool IsSatisfiedBy(T item)
    {
        return _left.IsSatisfiedBy(item) && _right.IsSatisfiedBy(item);
    }
    
    public static AndSpecification<T> operator &(AndSpecification<T> left, AndSpecification<T> right)
    {
        return new AndSpecification<T>(left, right);
    }
}