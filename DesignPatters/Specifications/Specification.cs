namespace DesignPatters.Specifications;

public abstract class Specification<T> : ISpecification<T>
{
    public abstract bool IsSatisfiedBy(T item);
    
    public static ISpecification<T> operator &(Specification<T> left, Specification<T> right)
    {
        return new AndSpecification<T>(left, right);
    }
}