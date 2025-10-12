namespace DesignPatters.Models.Mediator;

public class Actor
{
    protected readonly EventBroker Broker;

    public Actor(EventBroker broker)
    {
        Broker = broker ?? throw new ArgumentNullException(nameof(broker));
    }
}