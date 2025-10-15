using System.Dynamic;
using ImpromptuInterface;

namespace DesignPatters.Models.NullObjectPattern;

public sealed class NullLog : ILog
{
    private static readonly Lazy<NullLog> LazyInstance = new(() => new NullLog());
    public static NullLog Instance => LazyInstance.Value;
    
    private NullLog()
    {
        
    }
    
    public void Info(string msg)
    {
    }

    public void Warn(string msg)
    {
    }
}

public class Null<TInterface> : DynamicObject where TInterface : class
{
    public static TInterface Instance => new Null<TInterface>().ActLike<TInterface>();

    public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
    {
        result = Activator.CreateInstance(binder.ReturnType);
        return true;
    }
}