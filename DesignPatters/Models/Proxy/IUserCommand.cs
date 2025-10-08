namespace DesignPatters.Models.Proxy;

public interface IUserCommand
{
    public void Execute();
    public void Undo();
}