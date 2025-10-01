namespace DesignPatters.Models.Shapes;

public class Box : IStructure
{
    private float _side;

    public Box(float side)
    {
        _side = side;
    }

    public string AsString() => $"A Box with side: {_side}";
}