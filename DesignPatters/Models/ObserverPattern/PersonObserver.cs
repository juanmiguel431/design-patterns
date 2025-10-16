namespace DesignPatters.Models.ObserverPattern;

public class PersonObserver : IObserver<Event>
{
    public void OnCompleted()
    {
    }

    public void OnError(Exception error)
    {
    }

    public void OnNext(Event value)
    {
        if (value is FallsIllEvent fallsIllEvent)
        {
            Console.WriteLine($"A doctor is required at {fallsIllEvent.Address}");
        }
    }
}