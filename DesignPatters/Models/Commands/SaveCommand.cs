namespace DesignPatters.Models.Commands;

public class SaveCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Saving a file");
    }
}