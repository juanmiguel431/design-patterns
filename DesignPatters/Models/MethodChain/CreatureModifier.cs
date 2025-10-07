namespace DesignPatters.Models.MethodChain;

public class CreatureModifier
{
    protected readonly BigCreature Creature;
    private CreatureModifier? _next; // Linked List

    public CreatureModifier(BigCreature creature)
    {
        Creature = creature;
    }

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

    public virtual void Handle()
    {
        _next?.Handle();
    }
}