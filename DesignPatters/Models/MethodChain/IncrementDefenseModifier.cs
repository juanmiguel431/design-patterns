namespace DesignPatters.Models.MethodChain;

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