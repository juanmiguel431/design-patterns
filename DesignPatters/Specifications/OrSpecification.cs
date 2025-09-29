namespace DesignPatters.Specifications;

public class OrSpecification<T> : CompositeSpecification<T>
{
    public OrSpecification(params ISpecification<T>[] specifications) : base(specifications)
    {
    }
    
    public override bool IsSatisfiedBy(T item)
    {
        return Specifications.Any(spec => spec.IsSatisfiedBy(item));
    }
    
    public static OrSpecification<T> operator &(OrSpecification<T> left, OrSpecification<T> right)
    {
        return new OrSpecification<T>(left, right);
    }
}