namespace DesignPatters.Models.MethodChain;

public abstract class SmallCreatureModifier : IDisposable
{
    protected CreatureGame Game;
    protected SmallCreature Creature;

    protected SmallCreatureModifier(CreatureGame game, SmallCreature creature)
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