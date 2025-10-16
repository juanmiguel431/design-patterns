namespace DesignPatters.Models.ObserverPattern;

public class Window
{
    private readonly WeakEventHandler<EventArgs> _onClickHandler;

    public Window(OButton button)
    {
        // button.Clicked += ButtonOnClicked;

        // Alternative to prevent memory leak
        _onClickHandler = new WeakEventHandler<EventArgs>(ButtonOnClicked);
        button.Clicked += _onClickHandler.Handler;
        
        Console.WriteLine("Window created.");
    }

    private void ButtonOnClicked(object? sender, EventArgs e)
    {
        Console.WriteLine("Button clicked. (Window handler)");
    }
    
    ~Window()
    {
        Console.WriteLine("Window finalized.");
    }
}