namespace DesignPatters.Models.TemplateMethod;

public class PermanentCardDamage : CardGame
{
    public PermanentCardDamage(CardCreature[] creatures) : base(creatures)
    {
    }

    protected override void Hit(CardCreature attacker, CardCreature other)
    {
        other.Health -= attacker.Attack;
    }
}