namespace DesignPatters.Models.Flyweight;

public class ThreeTypeFactory
{
    private readonly Dictionary<string, ThreeType> _types = new();
    
    public ThreeType GetType(string name, string color, string texture)
    {
        var success = _types.TryGetValue(name, out var value);
        if (!success)
        {
            value = new ThreeType(name, color, texture);
            _types.Add(name, value);
        }
        
        return value!;
    }
}