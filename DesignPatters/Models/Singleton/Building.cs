using System.Text;

namespace DesignPatters.Models.Singleton;

public class Building
{
    public List<Wall> Walls { get; set; } = [];

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var wall in Walls)
        {
            sb.AppendLine(wall.ToString());
        }

        return sb.ToString();
    }
}