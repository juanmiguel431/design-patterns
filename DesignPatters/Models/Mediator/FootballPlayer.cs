using System.Reactive.Linq;

namespace DesignPatters.Models.Mediator;

public class FootballPlayer : Actor
{
    private readonly EventBroker _broker;
    public string Name { get; set; }
    public int GoalsScored { get; set; }
    
    public FootballPlayer(EventBroker broker, string name) : base(broker)
    {
        _broker = broker;
        Name = name ?? throw new ArgumentNullException(nameof(name));

        broker.OfType<PlayerScoredEvent>().Where(p => !string.Equals(p.Name, Name)).Subscribe(pe =>
        {
            Console.WriteLine($"{Name}: nicely done, {pe.Name}! It's your {pe.GoalScored} goal.");
        });

        broker.OfType<PlayerSentOffEvent>().Where(p => !string.Equals(p.Name, Name)).Subscribe(pe =>
        {
            Console.WriteLine($"{Name}: See you in the lockers, {pe.Name}");
        });
    }

    public void Score()
    {
        GoalsScored++;
        _broker.Publish(new PlayerScoredEvent()
        {
            Name = Name,
            GoalScored = GoalsScored
        });
    }

    public void AssaultReferee()
    {
        _broker.Publish(new PlayerSentOffEvent()
        {
            Name = Name,
            Reason = "Violence"
        });   
    }
}