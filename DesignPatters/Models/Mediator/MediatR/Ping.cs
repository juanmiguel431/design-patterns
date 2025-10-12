using MediatR;

namespace DesignPatters.Models.Mediator.MediatR;

public class PingCommand : IRequest<PongResponse>
{
    
}