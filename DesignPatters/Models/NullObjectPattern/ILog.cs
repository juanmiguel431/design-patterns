namespace DesignPatters.Models.NullObjectPattern;

public interface ILog
{
    void Info(string msg);
    void Warn(string msg);
}