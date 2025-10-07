namespace DesignPatters.Models.MethodChain;

public abstract class SmallCreatureModifier : IDisposable
{
    protected Game Game;
    protected SmallCreature Creature;

    protected SmallCreatureModifier(Game game, SmallCreature creature)
    {
        Game = game ?? throw new ArgumentNullException(nameof(game));
        Creature = creature ?? throw new ArgumentNullException(nameof(creature));
        
        Game.Queries += Handle;
    }
    
    public abstract void Handle(object? sender, Query query);

    public void Dispose()
    {
        Game.Queries -= Handle;
    }
}

public class TripleAttackModifier : SmallCreatureModifier
{
    public TripleAttackModifier(Game game, SmallCreature creature) : base(game, creature)
    {
    }

    public override void Handle(object? sender, Query query)
    {
        if (Creature.Name == query.CreatureName && query.WhatToQuery == Query.Argument.Attack)
        {
            query.Value *= 3;
        }
    }
}

public class IncrementDefenseModifier : SmallCreatureModifier
{
    private readonly int _value;

    public IncrementDefenseModifier(Game game, SmallCreature creature, int value) : base(game, creature)
    {
        _value = value;
    }

    public override void Handle(object? sender, Query query)
    {
        if (Creature.Name == query.CreatureName && query.WhatToQuery == Query.Argument.Defence)
        {
            query.Value += _value;
        }
    }
}