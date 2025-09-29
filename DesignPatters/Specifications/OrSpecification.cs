namespace DesignPatters.Specifications;

public class OrSpecification<T> : Specification<T>
{
    private readonly ISpecification<T> _left, _right;

    public OrSpecification(ISpecification<T> left, ISpecification<T> right)
    {
        _left = left;
        _right = right;
    }
    
    public override bool IsSatisfiedBy(T item)
    {
        return _left.IsSatisfiedBy(item) || _right.IsSatisfiedBy(item);
    }
    
    public static OrSpecification<T> operator &(OrSpecification<T> left, OrSpecification<T> right)
    {
        return new OrSpecification<T>(left, right);
    }
}