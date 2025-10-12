namespace DesignPatters.Models.Mediator;

public class Actor
{
    protected EventBroker _broker;

    public Actor(EventBroker broker)
    {
        _broker = broker ?? throw new ArgumentNullException(nameof(broker));
    }
}