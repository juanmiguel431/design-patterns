namespace DesignPatters.Models.ObserverPattern.Declarative;

public class ButtonPressedEvent : IEvent
{
    public int NumberOfClicks { get; set; }
}