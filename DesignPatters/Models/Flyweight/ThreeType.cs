namespace DesignPatters.Models.Flyweight;

public class ThreeType
{
    public string Name { get; set; }
    public string Color { get; set; }
    public string Texture { get; set; }
    
    public ThreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }
}