namespace DesignPatters.Models.Proxy;

public interface IUserCommand
{
    void Execute();
    void Undo();
    bool Success { get; set; }
}