namespace DesignPatters.Models.MethodChain;

public class SimpleGame
{
    public IList<MediumCreature> Creatures = [];

    public int CalcDefense(MediumCreature creature)
    {
        var item = Creatures.SingleOrDefault(c => c.Equals(creature));
        if (item is null) return 0;

        return item.GetType() == typeof(GoblinKing) ? 3 : Creatures.Count;
    }

    public int CalcAttack(MediumCreature creature)
    {
        var item = Creatures.SingleOrDefault(c => c.Equals(creature));
        if (item is null) return 0;

        if (item.GetType() == typeof(GoblinKing))
        {
            return 3;
        }
        
        var kingsCount = Creatures.Count(c => c.GetType() == typeof(GoblinKing));

        return 1 + kingsCount;
    }
}