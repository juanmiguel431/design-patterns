namespace DesignPatters.Models.Mediator.MediatR;

public class PongResponse
{
    public DateTime Timestamp { get; set; }
    
    public PongResponse(DateTime timestamp)
    {
        Timestamp = timestamp;
    }
}