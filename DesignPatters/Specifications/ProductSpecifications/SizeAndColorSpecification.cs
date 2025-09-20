using DesignPatters.Models;

namespace DesignPatters.Specifications.ProductSpecifications;

public class SizeAndColorSpecification : ISpecification<Product>
{
    private readonly Color _color;
    private readonly Size _size;

    public SizeAndColorSpecification(Color color, Size size)
    {
        _color = color;
        _size = size;
    }
    
    public bool IsSatisfiedBy(Product item)
    {
        return item.Size == _size && item.Color == _color;
    }
}