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
        
        var allowed = Policy.ApplicationAllowed(Types[0], Types.Skip(1).ToArray());
        
        if (allowed) 
            sb.Append($" has the transparency of {_transparency * 100}%");

        return sb.ToString();
    }
}

public class TransparentStructure<T> : Structure
    where T : IStructure, new()
{
    private readonly float _transparency;
    private readonly T _structure = new();

    public TransparentStructure() : this(0)
    {
    }
    
    public TransparentStructure(float transparency)
    {
        _transparency = transparency;
    }

    public override string AsString()
    {
        return $"{_structure.AsString()} has the transparency of {_transparency * 100}%";
    }
}