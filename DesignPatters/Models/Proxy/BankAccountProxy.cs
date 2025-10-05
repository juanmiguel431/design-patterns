using System.Reflection;

namespace DesignPatters.Models.Proxy;

public class BankAccountProxy : DispatchProxy
{
    private readonly IBankAccount _bankAccount = new BankAccount();
    private readonly Dictionary<string, int> _methodCallCounts = new();
    
    public static IBankAccount Create()
    {
        return Create<IBankAccount, BankAccountProxy>();
    }

    protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
    {
        if (targetMethod is null) return null;
        
        var arguments = args ?? [];
        
        Console.WriteLine($"Invoking {targetMethod.Name} with arguments [{string.Join(",", arguments)}]");
        
        if (!_methodCallCounts.TryAdd(targetMethod.Name, 1))
        {
            _methodCallCounts[targetMethod.Name]++;
        }
        
        return targetMethod.Invoke(_bankAccount, args);
    }
}