namespace DesignPatters.Models.Commands;

public class Button
{
    private readonly ICommand _command;
    private string _name;

    public Button(ICommand command, string name = "Button")
    {
        _command = command ?? throw new ArgumentNullException(nameof(command));
        _name = name;
    }
    
    public void Click()
    {
        _command.Execute();
    }
    
    public void PrintMe()
    {
        Console.WriteLine($"I am a button called {_name}");
    }
}