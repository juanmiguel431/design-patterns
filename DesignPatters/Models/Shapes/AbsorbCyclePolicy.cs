namespace DesignPatters.Models.Shapes;

public class AbsorbCyclePolicy : StructureDecoratorCyclePolicy
{
    public override void TypeAdditionAllowed(Type type, IList<Type> allTypes)
    {
    }

    public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
    {
        return !allTypes.Contains(type);
    }
}