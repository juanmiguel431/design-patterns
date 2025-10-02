namespace DesignPatters.Models.Shapes;

public class ColoredStructure : StructureDecoratorWithPolicy<ColoredStructure>
{
    private readonly string _color;

    public ColoredStructure(IStructure structure, string color) : base(structure)
    {
        _color = color ?? throw new ArgumentNullException(nameof(color));
    }

    public override string AsString() => $"{Structure.AsString()} has the color {_color}";
}