using System.Reactive.Linq;

namespace DesignPatters.Models.Mediator;

public class FootballPlayer : Actor
{
    private readonly IDisposable _scoredSubscription;
    private readonly IDisposable _sentOffSubscription;
    public string Name { get; set; }
    public int GoalsScored { get; set; }
    
    public FootballPlayer(EventBroker broker, string name) : base(broker)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));

        _scoredSubscription = Broker.OfType<PlayerScoredEvent>().Where(p => !string.Equals(p.Name, Name)).Subscribe(pe =>
        {
            Console.WriteLine($"{Name}: nicely done, {pe.Name}! It's your {pe.GoalScored} goal.");
        });

        _sentOffSubscription = Broker.OfType<PlayerSentOffEvent>().Where(p => !string.Equals(p.Name, Name)).Subscribe(pe =>
        {
            Console.WriteLine($"{Name}: See you in the lockers, {pe.Name}");
        });
    }

    public void Score()
    {
        GoalsScored++;
        Broker.Publish(new PlayerScoredEvent()
        {
            Name = Name,
            GoalScored = GoalsScored
        });
    }

    public void AssaultReferee()
    {
        Broker.Publish(new PlayerSentOffEvent()
        {
            Name = Name,
            Reason = "Violence"
        });
        
        LeaveGame();
    }

    private void LeaveGame()
    {
        _scoredSubscription.Dispose();
        _sentOffSubscription.Dispose();
    }
}