namespace DesignPatters.Models;

public class CodeBuilder
{
    private readonly string _className;
    private readonly List<(string, string)> _fields = [];

    public CodeBuilder(string className)
    {
        _className = className;
    }

    public CodeBuilder AddField(string name, string type)
    {
        _fields.Add((name, type));
        return this;
    }

    public override string ToString()
    {
        var fields = string.Join("", _fields.Select(f => $"  public {f.Item2} {f.Item1};\n"));
        return $"public class {_className}\n{{\n{fields}}}\n";
    }
}