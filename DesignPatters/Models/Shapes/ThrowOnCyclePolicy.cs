namespace DesignPatters.Models.Shapes;

public class ThrowOnCyclePolicy : StructureDecoratorCyclePolicy
{
    private void Handler(Type type, IList<Type> allTypes)
    {
        if (allTypes.Contains(type))
        {
            throw new InvalidOperationException($"Cycle detected. Type is already a {type.FullName}");
        }
    }
    
    public override void TypeAdditionAllowed(Type type, IList<Type> allTypes)
    {
        Handler(type, allTypes);
    }

    public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
    {
        Handler(type, allTypes);
        return true;
    }
}