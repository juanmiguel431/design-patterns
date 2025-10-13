namespace DesignPatters.Models.Mediator;

public class SampleMediator
{
    public event Action<Participant, int>? Alert;

    public void Publish(Participant participant, int value)
    {
        Alert?.Invoke(participant, value);
    }
}