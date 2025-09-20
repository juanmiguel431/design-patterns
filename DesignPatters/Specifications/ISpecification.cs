namespace DesignPatters;

public interface ISpecification<in T>
{
    bool IsSatisfiedBy(T item);
}