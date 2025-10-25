namespace DesignPatters.Models.MethodChain;

public class CreatureGame
{
    public event EventHandler<Query> Queries;
    public void PerformQuery(object? sender, Query q)
    {
        Queries?.Invoke(sender, q);
    }
}