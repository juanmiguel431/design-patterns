namespace DesignPatters.Models.Shapes;

public abstract class StructureDecorator<TSelf, TCyclePolicy> : StructureDecorator
    where TCyclePolicy : StructureDecoratorCyclePolicy, new()
{
    protected readonly TCyclePolicy CyclePolicy = new();
    protected StructureDecorator(IStructure structure) : base(structure)
    {
        CyclePolicy.TypeAdditionAllowed(typeof(TSelf), Types);
        Types.Add(typeof(TSelf));
    }
}

public abstract class StructureDecorator : IStructure
{
    protected internal readonly List<Type> Types = new();
    protected internal IStructure Structure;

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