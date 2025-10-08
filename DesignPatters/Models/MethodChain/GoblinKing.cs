namespace DesignPatters.Models.MethodChain;

public class GoblinKing : Goblin
{
    public GoblinKing(SimpleGame game): base(game)
    {
        
    }
    
    public override string ToString()
    {
        return $"I am a King goblin with attack {Attack} and defense {Defense}";
    }
}