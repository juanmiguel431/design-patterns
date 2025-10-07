namespace DesignPatters.Models.MethodChain;

public class CreatureModifier
{
    private CreatureModifier? _next; // Linked List

    public void Add(CreatureModifier modifier)
    {
        if (_next == null)
        {
            _next = modifier;
        }
        else
        {
            _next.Add(modifier);
        }
    }

    public virtual void Handle(BigCreature creature)
    {
        _next?.Handle(creature);
    }
}