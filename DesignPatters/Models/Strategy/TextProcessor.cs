using System.Text;

namespace DesignPatters.Models.Strategy;

public class TextProcessor
{
    private IListStrategy _strategy;
    private StringBuilder _sb = new StringBuilder();
    
    public void SetOutputFormat(OutputFormat format)
    {
        _strategy = format switch
        {
            OutputFormat.Markdown => new MarkdownListStrategy(),
            OutputFormat.Html => new HtmlListStrategy(),
            _ => throw new ArgumentOutOfRangeException(nameof(format), format, null)
        };
    }
    
    public void AppendList(IEnumerable<string> items)
    {
        _strategy.Start(_sb);
        foreach (var item in items)
        {
            _strategy.Add(_sb, item);
        }
        _strategy.End(_sb);
    }
    
    public override string ToString()
    {
        return _sb.ToString();
    }

    public StringBuilder Clear()
    {
        return _sb.Clear();
    }
}