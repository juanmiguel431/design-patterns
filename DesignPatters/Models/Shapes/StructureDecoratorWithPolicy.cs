namespace DesignPatters.Models.Shapes;

// CyclesAllowedPolicy
// ThrowOnCyclePolicy
// AbsorbCyclePolicy
public class StructureDecoratorWithPolicy<T> : StructureDecorator<T, AbsorbCyclePolicy>
{
    public StructureDecoratorWithPolicy(IStructure structure) : base(structure)
    {
    }
}