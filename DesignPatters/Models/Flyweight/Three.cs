namespace DesignPatters.Models.Flyweight;

public class Three
{
    public ThreeType Type { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
    
    public Three(ThreeType type, float x, float y)
    {
        Type = type ?? throw new ArgumentNullException(nameof(type));
        X = x;
        Y = y;
    }
    
    public override string ToString()
    {
        return $"{Type.Name} {Type.Color} {Type.Texture} at {X}, {Y}";
    }
}