namespace DesignPatters.Models.MethodChain;

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