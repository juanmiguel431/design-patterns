namespace DesignPatters.Models.Shapes;

public class ColoredStructure : StructureDecoratorWithPolicy<ColoredStructure>
{
    private readonly string _color;

    public ColoredStructure(IStructure structure, string color) : base(structure)
    {
        _color = color ?? throw new ArgumentNullException(nameof(color));
    }

    public override string AsString()
    {
        var sb = new MyStringBuilder(Structure.AsString());
        
        var allowed = Policy.ApplicationAllowed(Types[0], Types.Skip(1).ToArray());
        
        if (allowed) 
            sb.Append($" has the color {_color}");

        return sb.ToString();
    }
}