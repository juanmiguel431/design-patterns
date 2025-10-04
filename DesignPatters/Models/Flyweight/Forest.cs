namespace DesignPatters.Models.Flyweight;

public class Forest : List<Three>
{
    public override string ToString()
    {
        var sb = new MyStringBuilder();
        foreach (var three in this)
        {
            sb.AppendLine(three.ToString());
        }
        
        return sb.ToString();
    }
}