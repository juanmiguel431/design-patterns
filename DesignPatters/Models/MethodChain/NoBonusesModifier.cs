namespace DesignPatters.Models.MethodChain;

public class NoBonusesModifier : CreatureModifier
{
    public override void Handle(BigCreature creature)
    {
        Console.WriteLine($"No bonuses for {creature.Name}");
    }
}