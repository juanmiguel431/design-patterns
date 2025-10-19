using System.Text;

namespace DesignPatters.Models.Strategy;

public class MarkdownListStrategy : IListStrategy
{
    public void Start(StringBuilder sb)
    {
        
    }

    public void End(StringBuilder sb)
    {
        
    }

    public void Add(StringBuilder sb, string item)
    {
        sb.AppendLine($" * {item}");
    }
}