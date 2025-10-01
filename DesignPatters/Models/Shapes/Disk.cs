namespace DesignPatters.Models.Shapes;

public class Disk : IStructure
{
    private float _radius;

    public Disk(float radius)
    {
        _radius = radius;
    }

    public void Resize(float factor)
    {
        _radius *= factor;
    }

    public string AsString() => $"A Disk with radius: {_radius}";
}