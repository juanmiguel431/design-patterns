namespace DesignPatters.Models.NullObjectPattern;

public class ConsoleLog : ILog
{
    public void Info(string msg)
    {
        Console.WriteLine(msg);
    }

    public void Warn(string msg)
    {
        Console.WriteLine($"WARNING!!! {msg}");
    }
}