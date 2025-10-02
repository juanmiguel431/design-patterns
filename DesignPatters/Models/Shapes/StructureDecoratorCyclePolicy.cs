namespace DesignPatters.Models.Shapes;

public abstract class StructureDecoratorCyclePolicy
{
    public abstract void TypeAdditionAllowed(Type type, IList<Type> allTypes);
    public abstract void ApplicationAllowed(Type type, IList<Type> allTypes);
}