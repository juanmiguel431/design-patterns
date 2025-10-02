namespace DesignPatters.Models.Shapes;

public abstract class StructureDecorator<TSelf, TPolicy> : StructureDecorator
    where TPolicy : StructureDecoratorCyclePolicy, new()
{
    protected readonly TPolicy Policy = new();
    protected StructureDecorator(IStructure structure) : base(structure)
    {
        Policy.TypeAdditionAllowed(typeof(TSelf), Types);
        Types.Add(typeof(TSelf));
    }
}

public abstract class StructureDecorator : IStructure
{
    protected readonly List<Type> Types = new();
    protected readonly IStructure Structure;

    protected StructureDecorator(IStructure structure)
    {
        Structure = structure ?? throw new ArgumentNullException(nameof(structure));

        if (structure is StructureDecorator sd)
        {
            Types.AddRange(sd.Types);
        }
    }

    public virtual string AsString() => Structure.AsString();
}