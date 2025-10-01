namespace DesignPatters.Models.Shapes;

public class ColoredStructure : IStructure
{
    private readonly IStructure _structure;
    
    private readonly string _color;

    public ColoredStructure(IStructure structure, string color)
    {
        if (structure is ColoredStructure)
        {
            throw new ArgumentException("Cannot add a colored structure to another colored structure");
        }
        
        _structure = structure ?? throw new ArgumentNullException(nameof(structure));
        _color = color ?? throw new ArgumentNullException(nameof(color));
    }

    public string AsString()
    {
        return $"{_structure.AsString()} has the color {_color}";
    }
}