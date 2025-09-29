namespace DesignPatters.Specifications;

// combinator
public class AndSpecification<T> : CompositeSpecification<T>
{
    public AndSpecification(params ISpecification<T>[] specifications) : base(specifications)
    {
    }
    
    public override bool IsSatisfiedBy(T item)
    {
        return Specifications.All(spec => spec.IsSatisfiedBy(item));
    }
    
    public static AndSpecification<T> operator &(AndSpecification<T> left, AndSpecification<T> right)
    {
        return new AndSpecification<T>(left, right);
    }
}