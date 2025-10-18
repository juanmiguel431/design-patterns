namespace DesignPatters.Models.ObserverPattern.Declarative;

public interface IHandle<TEvent> where TEvent : IEvent
{
    void Handle(object sender, TEvent args);
}