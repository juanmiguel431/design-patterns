namespace DesignPatters.Models.ObserverPattern.Declarative;

public class DButton : ISend<ButtonPressedEvent>
{
    public event EventHandler<ButtonPressedEvent> Sender;

    public void Fire(int clicks)
    {
        Sender?.Invoke(this, new ButtonPressedEvent()
        {
            NumberOfClicks = clicks
        });
    }
}