namespace DesignPatters.Models;

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

public enum Color
{
    Red, Green, Blue
}

public enum Size
{
    Small, Medium, Large, Huge
}