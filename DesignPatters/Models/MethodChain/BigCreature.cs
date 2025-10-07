using System.Reflection.Metadata;

namespace DesignPatters.Models.MethodChain;

public class BigCreature
{
    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defence { get; set; }

    public BigCreature(string name, int attack, int defence)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Attack = attack;
        Defence = defence;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defence)}: {Defence}";
    }
}