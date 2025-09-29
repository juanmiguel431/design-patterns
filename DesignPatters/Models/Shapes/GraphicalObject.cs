using System.Text;

namespace DesignPatters.Models.Shapes;

public class GraphicalObject
{
    public virtual string Name { get; set; } = "Group";
    public string Color { get; set; }

    private readonly Lazy<List<GraphicalObject>> _children = new();
    public List<GraphicalObject> Children => _children.Value;

    private void Print(StringBuilder sb, int depth)
    {
        sb.Append(new string('*', depth))
            .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : Color)
            .AppendLine(Name);

        foreach (var child in Children)
        {
            child.Print(sb, depth + 1);
        }
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        Print(sb, 0);
        return sb.ToString();
    }
}

public class CircleObject : GraphicalObject
{
    public override string Name => "Circle";
}

public class SquareObject : GraphicalObject
{
    public override string Name => "Square";
}