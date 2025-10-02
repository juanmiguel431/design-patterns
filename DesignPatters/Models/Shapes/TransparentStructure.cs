namespace DesignPatters.Models.Shapes;

public class TransparentStructure : StructureDecoratorWithPolicy<TransparentStructure>
{
    private readonly float _transparency;

    public TransparentStructure(IStructure structure, float transparency) : base(structure)
    {
        _transparency = transparency;
    }

    public override string AsString()
    {
        return $"{Structure.AsString()} has the transparency of {_transparency * 100}%";
    }
}