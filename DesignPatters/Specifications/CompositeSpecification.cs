namespace DesignPatters.Specifications;

public abstract class CompositeSpecification<T> : Specification<T>
{
    protected readonly ISpecification<T>[] Specifications;

    public CompositeSpecification(params ISpecification<T>[] specifications)
    {
        Specifications = specifications;
    }
}