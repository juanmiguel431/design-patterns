using JetBrains.Annotations;
using MediatR;

namespace DesignPatters.Models.Mediator.MediatR;

[UsedImplicitly]
public class PingCommandHandler : IRequestHandler<PingCommand, PongResponse>
{
    public Task<PongResponse> Handle(PingCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new PongResponse(DateTime.UtcNow));
    }
}