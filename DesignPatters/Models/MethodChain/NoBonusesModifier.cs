namespace DesignPatters.Models.MethodChain;

public class NoBonusesModifier : CreatureModifier
{
    public NoBonusesModifier(BigCreature creature) : base(creature)
    {
    }
    
    public override void Handle()
    {
        Console.WriteLine($"No bonuses for {Creature.Name}");
    }
}