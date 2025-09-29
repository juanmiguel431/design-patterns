using DesignPatters.Models.Products;
using DesignPatters.Specifications;

namespace DesignPatters.Filters;

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach (var item in items)
        {
            if (spec.IsSatisfiedBy(item))
            {
                yield return item;
            }
        }
    }
}