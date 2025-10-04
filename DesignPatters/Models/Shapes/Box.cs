namespace DesignPatters.Models.Shapes;

public class Box : Structure
{
    private float _side;

    public Box() : this(0)
    {
    }
    
    public Box(float side)
    {
        _side = side;
    }

    public override string AsString() => $"A Box with side: {_side}";
}

public abstract class Structure : IStructure
{
    public abstract string AsString();
}