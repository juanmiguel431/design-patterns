namespace DesignPatters.Models.ObserverPattern.Declarative;

public class Logging : IHandle<ButtonPressedEvent>
{
    public void Handle(object sender, ButtonPressedEvent args)
    {
        Console.WriteLine($"The button was pressed {args.NumberOfClicks} times.");
    }
}