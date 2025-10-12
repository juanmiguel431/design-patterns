namespace DesignPatters.Models.Mediator;

public class PlayerSentOffEvent : PlayerEvent
{
    public string Reason { get; set; }
}