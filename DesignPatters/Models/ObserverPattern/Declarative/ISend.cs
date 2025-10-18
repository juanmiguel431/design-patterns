namespace DesignPatters.Models.ObserverPattern.Declarative;

public interface ISend<TEvent> where TEvent : IEvent
{
    event EventHandler<TEvent> Sender;
}