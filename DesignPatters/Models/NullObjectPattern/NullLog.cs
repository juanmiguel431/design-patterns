namespace DesignPatters.Models.NullObjectPattern;

public class NullLog : ILog
{
    public void Info(string msg)
    {
    }

    public void Warn(string msg)
    {
    }
}