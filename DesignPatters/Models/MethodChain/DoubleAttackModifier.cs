namespace DesignPatters.Models.MethodChain;

public class DoubleAttackModifier : CreatureModifier
{
    public DoubleAttackModifier(BigCreature creature) : base(creature)
    {
    }

    public override void Handle()
    {
        Console.WriteLine($"Doubling {Creature.Name}'s attack");
        Creature.Attack *= 2;
        base.Handle();
    }
}