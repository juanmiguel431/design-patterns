using System.Collections;

namespace DesignPatters.Models.Iterator;

public class GameCreature: IEnumerable<int>
{
    private int[] _stats = new int[3];

    private const int strength = 0;
    
    public int Strength
    {
        get => _stats[strength];
        set => _stats[strength] = value;
    }

    public int Agility
    {
        get => _stats[1];
        set => _stats[1] = value;
    }

    public int Intelligence
    {
        get => _stats[2];
        set => _stats[2] = value;
    }

    public double AverageStat => _stats.Average();

    public IEnumerator<int> GetEnumerator()
    {
        return _stats.AsEnumerable().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int this[int index]
    {
        get => _stats[index];
        set => _stats[index] = value;
    }
}