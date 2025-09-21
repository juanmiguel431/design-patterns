namespace DesignPatters.Models;

public class HtmlBuilder
{
    private readonly string _rootName;
    private HtmlElement _root = new ();

    public HtmlBuilder(string rootName)
    {
        _rootName = rootName;
        _root.Name = rootName;
    }
    
    public void AddChild(string childName, string childText)
    {
        var child = new HtmlElement(childName, childText);
        _root.Children.Add(child);
    }

    public override string ToString()
    {
        return _root.ToString();
    }
    
    public void Clear()
    {
        _root = new HtmlElement();
        _root.Name = _rootName;
    }
}