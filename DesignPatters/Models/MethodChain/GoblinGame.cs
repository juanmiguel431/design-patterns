namespace DesignPatters.Models.MethodChain;

public class GoblinGame
{
    public readonly IList<BaseCreature> Creatures = [];
}

public class DefenseQuery
{
    public int Defense { get; set; }
}

public class AttackQuery
{
    public int Attack { get; set; }
}


public abstract class BaseCreature
{
    private readonly GoblinGame _game;

    protected int _attack;
    public int Attack
    {
        get
        {
            var exists = _game.Creatures.Any(p => p == this);
            if (!exists) return _attack;
            
            var query = new AttackQuery { Attack = _attack };
            foreach (var creature in _game.Creatures)
            {
                creature.PerformAttackQuery(this, query);
            }
            
            return query.Attack;
        }
    }

    protected int _defense;
    public int Defense
    {
        get
        {
            var exists = _game.Creatures.Any(p => p == this);
            if (!exists) return _defense;
            
            var query = new DefenseQuery { Defense = _defense };
            foreach (var creature in _game.Creatures)
            {
                creature.PerformDefenseQuery(this, query);
            }
            
            return query.Defense;
        }
    }

    public override string ToString()
    {
        return $"{GetType().Name} ({Attack}/{Defense})";
    }

    public BaseCreature(GoblinGame game)
    {
        _game = game;
    }
    
    protected abstract void PerformDefenseQuery(object? sender, DefenseQuery e);
    protected abstract void PerformAttackQuery(object? sender, AttackQuery e);
}

public class SimpleGoblin : BaseCreature
{
    public SimpleGoblin(GoblinGame game, int attack = 1, int defense = 1) : base(game)
    {
        _attack = attack;
        _defense = defense;
    }

    protected override void PerformDefenseQuery(object? sender, DefenseQuery e)
    {
        if (sender == this) return;
        
        e.Defense++;
    }

    protected override void PerformAttackQuery(object? sender, AttackQuery e)
    {
        if (sender == this) return;

        // if (sender is GoblinMaster)
        if (this is GoblinMaster)
        {
            e.Attack++;
        }
    }
}

public class GoblinMaster : SimpleGoblin
{
    public GoblinMaster(GoblinGame game) : base(game, 3, 3)
    {
    }
}

// Chain of Responsibility Coding Exercise
//     You are given a game scenario with classes Goblin and GoblinKing. Please implement the following rules:
//
// A goblin has base 1 attack/1 defense (1/1), a goblin king is 3/3.
//     When the Goblin King is in play, every other goblin gets +1 Attack.
//     Goblins get +1 to Defense for every other Goblin in play (a GoblinKing is a Goblin!).
//     Example:
//
// Suppose you have 3 ordinary goblins in play. Each one is a 1/3 (1/1 + 0/2 defense bonus).
//     A goblin king comes into play. Now every goblin is a 2/4 (1/1 + 0/3 defense bonus from each other + 1/0 from goblin king)
// The state of all the goblins has to be consistent as goblins are added and removed from the game.