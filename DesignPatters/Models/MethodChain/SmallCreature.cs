namespace DesignPatters.Models.MethodChain;

public class SmallCreature
{
    private CreatureGame _game;
    private string _name;
    private int _attack;
    private int _defense;

    public SmallCreature(CreatureGame game, string name, int attack, int defense)
    {
        _game = game;
        _name = name;
        _attack = attack;
        _defense = defense;
    }
    
    public string Name => _name;

    public int Attack
    {
        get
        {
            var q = new Query(_name, Query.Argument.Attack, _attack);
            _game.PerformQuery(this, q);
            return q.Value;
        }
    }
    
    public int Defense
    {
        get
        {
            var q = new Query(_name, Query.Argument.Defence, _defense);
            _game.PerformQuery(this, q);
            return q.Value;
        }
    }

    public override string ToString()
    {
        return $"{nameof(_name)}: {_name}, {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
    }
}