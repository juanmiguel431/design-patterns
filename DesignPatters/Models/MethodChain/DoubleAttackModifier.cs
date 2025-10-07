namespace DesignPatters.Models.MethodChain;

public class DoubleAttackModifier : CreatureModifier
{
    public override void Handle(BigCreature creature)
    {
        Console.WriteLine($"Doubling {creature.Name}'s attack");
        creature.Attack *= 2;
        base.Handle(creature);
    }
}