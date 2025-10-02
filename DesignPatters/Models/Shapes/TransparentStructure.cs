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
        var sb = new MyStringBuilder(Structure.AsString());
        
        var allowed = CyclePolicy.ApplicationAllowed(Types[0], Types.Skip(1).ToArray());
        
        if (allowed) 
            sb.Append($" has the transparency of {_transparency * 100}%");

        return sb.ToString();
    }
}