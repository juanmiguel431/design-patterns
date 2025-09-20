using DesignPatters.Models;

namespace DesignPatters.Specifications.ProductSpecifications;

public class ColorSpecification : ISpecification<Product>
{
    private readonly Color _color;

    public ColorSpecification(Color color)
    {
        _color = color;
    }
    
    public bool IsSatisfiedBy(Product item)
    {
        return item.Color == _color;
    }
}