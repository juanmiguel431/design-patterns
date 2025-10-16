namespace DesignPatters.Models.ObserverPattern;

public class OButton
{
    public event EventHandler? Clicked;

    public void Fire()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }

    ~OButton()
    {
        Console.WriteLine("Button finalized.");
    }
}