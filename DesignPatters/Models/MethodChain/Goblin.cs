namespace DesignPatters.Models.MethodChain;

public class Goblin : MediumCreature
{
    public Goblin(SimpleGame game) : base(game)
    {
        
    }

    public override string ToString()
    {
        return $"I am a goblin with attack {Attack} and defense {Defense}";
    }
}