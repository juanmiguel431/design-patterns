using System.Dynamic;
using System.Reflection;
using ImpromptuInterface;

namespace DesignPatters.Models.NullObjectPattern;

public sealed class NullLog : ILog
{
    private static readonly Lazy<NullLog> LazyInstance = new(() => new NullLog());
    public static NullLog Instance => LazyInstance.Value;
    
    private NullLog()
    {
        
    }
    
    public int Info(string msg)
    {
        return 0;
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

public class NullProxy<T> : DispatchProxy where T : class
{
    protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
    {
        if (targetMethod == null) return null;

        if (targetMethod.ReturnType == typeof(void))
        {
            return null;
        }
        
        if (targetMethod.ReturnType.IsValueType)
        {
            return Activator.CreateInstance(targetMethod.ReturnType);
        }
        
        return null;
    }

    public static T Create()
    {
        return DispatchProxy.Create<T, NullProxy<T>>();
    }
}