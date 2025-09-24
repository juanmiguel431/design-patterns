namespace DesignPatters.Models.Products;

public class Product
{
    public string Name { get; set; }
    public Color Color { get; set; }
    public Size Size { get; set; }
    
    public Product(string name, Color color, Size size)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be empty", nameof(name));
        }
        
        Name = name;
        Color = color;
        Size = size;
    }
}