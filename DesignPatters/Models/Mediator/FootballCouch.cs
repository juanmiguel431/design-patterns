using System.Reactive.Linq;

namespace DesignPatters.Models.Mediator;

public class FootballCouch : Actor
{
    public FootballCouch(EventBroker broker) : base(broker)
    {
        broker.OfType<PlayerScoredEvent>().Subscribe(pe =>
        {
            if (pe.GoalScored < 3)
            {
                Console.WriteLine($"Coach: Well done, {pe.Name}!");
            }
        });

        broker.OfType<PlayerSentOffEvent>().Subscribe(pe =>
        {
            if (pe.Reason == "Violence")
            {
                Console.WriteLine($"Coach: How could you, {pe.Name}.");
            }
        });
    }
}