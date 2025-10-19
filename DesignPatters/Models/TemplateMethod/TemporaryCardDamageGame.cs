namespace DesignPatters.Models.TemplateMethod;

public class TemporaryCardDamageGame : CardGame
{
    public TemporaryCardDamageGame(CardCreature[] creatures) : base(creatures)
    {
    }

    protected override void Hit(CardCreature attacker, CardCreature other)
    {
        var healthAfterDamage = other.Health - attacker.Attack;
        if (healthAfterDamage <= 0)
        {
            other.Health = 0;
        }
    }
}