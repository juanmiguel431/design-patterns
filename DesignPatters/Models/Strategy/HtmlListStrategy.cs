using System.Text;

namespace DesignPatters.Models.Strategy;

public class HtmlListStrategy : IListStrategy
{
    public void Start(StringBuilder sb)
    {
        sb.AppendLine("<ul>");
    }

    public void End(StringBuilder sb)
    {
        sb.AppendLine("</ul>");
    }

    public void Add(StringBuilder sb, string item)
    {
        sb.AppendLine($"  <li>{item}</li>");
    }
}