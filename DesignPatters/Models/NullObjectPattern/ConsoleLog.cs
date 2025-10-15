namespace DesignPatters.Models.NullObjectPattern;

public class ConsoleLog : ILog
{
    public int Info(string msg)
    {
        Console.WriteLine(msg);
        return 1;
    }

    public void Warn(string msg)
    {
        Console.WriteLine($"WARNING!!! {msg}");
    }
}