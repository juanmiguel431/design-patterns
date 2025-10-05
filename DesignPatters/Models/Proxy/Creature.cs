namespace DesignPatters.Models.Proxy;

public class Creature
{
    private readonly Property<int> _agility = new();

    public int Agility
    {
        get => _agility.Value;
        set => _agility.Value = value;
    }
}
