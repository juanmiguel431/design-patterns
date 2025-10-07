namespace DesignPatters.Models.MethodChain;

public class IncreaseDefenseModifier : CreatureModifier
{
    public IncreaseDefenseModifier(BigCreature creature) : base(creature)
    {
    }
    
    public override void Handle()
    {
        Console.WriteLine($"Increasing {Creature.Name}'s defense");
        Creature.Defence += 3;
        base.Handle();
    }
}