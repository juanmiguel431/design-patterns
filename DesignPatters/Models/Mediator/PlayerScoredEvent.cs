namespace DesignPatters.Models.Mediator;

public class PlayerScoredEvent : PlayerEvent
{
    public int GoalScored { get; set; }
}