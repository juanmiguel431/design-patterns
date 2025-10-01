namespace DesignPatters.Models.Shapes;

public class TransparentStructure : IStructure
{
    private readonly IStructure _structure;
    
    private readonly float _transparency;

    public TransparentStructure(IStructure structure, float transparency)
    {
        _structure = structure ?? throw new ArgumentNullException(nameof(structure));
        _transparency = transparency;
    }

    public string AsString()
    {
        return $"{_structure.AsString()} has the transparency of {_transparency * 100}%";
    }
}