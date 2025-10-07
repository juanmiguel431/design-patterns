namespace DesignPatters.Models.MethodChain;

public class IncreaseDefenseModifier : CreatureModifier
{
    private readonly int _value;

    public IncreaseDefenseModifier(int value)
    {
        _value = value;
    }
    
    public override void Handle(BigCreature creature)
    {
        Console.WriteLine($"Increasing {creature.Name}'s defense");
        creature.Defence += _value;
        base.Handle(creature);
    }
}