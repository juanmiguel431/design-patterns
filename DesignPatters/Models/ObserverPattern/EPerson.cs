namespace DesignPatters.Models.ObserverPattern;

public class EPerson : IObservable<Event>
{
    private readonly HashSet<Subscription> _subscriptions = [];

    public void FallIll()
    {
        foreach (var subscription in _subscriptions)
        {
            subscription.Observer.OnNext(new FallsIllEvent()
            {
                Address = "123 London Road"
            });
        }
    }
    
    public IDisposable Subscribe(IObserver<Event> observer)
    {
        var subscription = new Subscription(this, observer);
        _subscriptions.Add(subscription);
        return subscription;
    }
    
    private class Subscription : IDisposable
    {
        private readonly EPerson _person;
        private readonly IObserver<Event> _observer;
        public IObserver<Event> Observer => _observer;

        public Subscription(EPerson person, IObserver<Event> observer)
        {
            _person = person;
            _observer = observer;
        }
        
        public void Dispose()
        {
            _person._subscriptions.Remove(this);
        }
    }
}