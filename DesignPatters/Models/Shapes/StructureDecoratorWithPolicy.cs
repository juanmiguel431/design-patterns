namespace DesignPatters.Models.Shapes;

public class StructureDecoratorWithPolicy<T> : StructureDecorator<T, ThrowOnCyclePolicy>
{
    public StructureDecoratorWithPolicy(IStructure structure) : base(structure)
    {
    }
}