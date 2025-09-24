using System.Text;

namespace DesignPatters.Models.Html;

public class HtmlElement
{
    public string Name { get; set; }
    public string? Text { get; set; }
    public List<HtmlElement> Children { get; set; }
    private const int IndentSize = 2;

    public HtmlElement(string name, string? text = null)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Text = text;
        Children = [];
    }

    public string ToString(int indent)
    {
        var sb = new StringBuilder();
        var i = new string(' ', indent * IndentSize);
        sb.AppendLine($"{i}<{Name}>");

        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', (indent + 1) * IndentSize));
            sb.AppendLine(Text);
        }

        foreach (var child in Children)
        {
            sb.Append(child.ToString(indent + 1));
        }
        
        sb.AppendLine($"{i}</{Name}>");
        
        return sb.ToString();
    }

    public override string ToString()
    {
        return ToString(0);
    }
}