namespace DesignPatters.Models.Html;

public class HtmlBuilder
{
    private HtmlElement _root;

    public HtmlBuilder(string name, string? text = null)
    {
        _root = new HtmlElement(name, text);
    }
    
    public HtmlBuilder(HtmlElement root)
    {
        _root = root;
    }
    
    public HtmlBuilder AddChild(string name, string? text = null)
    {
        var child = new HtmlElement(name, text);
        _root.Children.Add(child);
        return new HtmlBuilder(child);
    }

    public override string ToString()
    {
        return _root.ToString();
    }
    
    public void Clear()
    {
        _root = new HtmlElement(_root.Name, _root.Text);
    }
}