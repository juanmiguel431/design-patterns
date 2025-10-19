namespace DesignPatters.Models.TemplateMethod;

public abstract class CardGame
{
    public CardCreature[] Creatures;

    public CardGame(CardCreature[] creatures)
    {
        Creatures = creatures;
    }

    // returns -1 if no clear winner (both alive or both dead)
    public int Combat(int creature1, int creature2)
    {
        CardCreature first = Creatures[creature1];
        CardCreature second = Creatures[creature2];
        Hit(first, second);
        Hit(second, first);
        bool firstAlive = first.Health > 0;
        bool secondAlive = second.Health > 0;
        if (firstAlive == secondAlive) return -1;
        return firstAlive ? creature1 : creature2;
    }

    // attacker hits other creature
    protected abstract void Hit(CardCreature attacker, CardCreature other);
}

// Template Method Coding Exercise
// Imagine a typical collectible card game which has cards representing creatures. 
//     Each creature has two values: Attack and Health. 
//     Creatures can fight each other, dealing their Attack damage, thereby reducing their opponent's health.
//
//     The class CardGame implements the logic for two creatures fighting one another. 
//     However, the exact mechanics of how damage is dealt is different:
//
// TemporaryCardDamage : In some games (e.g., Magic: the Gathering), unless the creature has been killed, its health returns to the original value at the end of combat.
// PermanentCardDamage : In other games (e.g., Hearthstone), health damage persists.
//     You are asked to implement classes TemporaryCardDamageGame  and PermanentCardDamageGame  that would allow us to simulate combat between creatures.
//
//     Some examples:
//
// With temporary damage, creatures 1/2 and 1/3 can never kill one another. With permanent damage, second creature will win after 2 rounds of combat.
//     With either temporary or permanent damage, two 2/2 creatures kill one another.