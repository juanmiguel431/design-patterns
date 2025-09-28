namespace DesignPatters.Models.Commands;

public class OpenCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Opening a file");
    }
}