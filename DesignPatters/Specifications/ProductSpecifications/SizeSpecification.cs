using DesignPatters.Models;
using DesignPatters.Models.Products;

namespace DesignPatters.Specifications.ProductSpecifications;

public class SizeSpecification : ISpecification<Product>
{
    private readonly Size _size;

    public SizeSpecification(Size size)
    {
        _size = size;
    }
    
    public bool IsSatisfiedBy(Product item)
    {
        return item.Size == _size;
    }
}