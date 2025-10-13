namespace DesignPatters.Models.Mediator;

public class SampleMediator
{
    private readonly List<Participant> _participants = [];
    
    public void Register(Participant participant)
    {
        _participants.Add(participant);
    }
    
    public void Publish(Participant source, int n)
    {
        foreach (var participant in _participants)
        {
            if (participant == source) continue;
            
            participant.Value += n;
        }
    }
}