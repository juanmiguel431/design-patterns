using System.Dynamic;
using System.Text;
using ImpromptuInterface;

namespace DesignPatters.Models.Proxy;

public class Log<T> : DynamicObject
    where T: class, new()
{
    private readonly T _subject;
    private Dictionary<string, int> _methodCallCounts = new();

    public Log(T subject)
    {
        _subject = subject;
    }

    public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
    {
        try
        {
            var subjectType = _subject.GetType();
            Console.WriteLine($"Invoking {subjectType.Name}.{binder.Name} with arguments [{string.Join(",", args)}]");

            if (!_methodCallCounts.TryAdd(binder.Name, 1))
            {
                _methodCallCounts[binder.Name]++;
            }

            result = subjectType.GetMethod(binder.Name).Invoke(_subject, args);
            
            return true;
        }
        catch (Exception e)
        {
            result = null;
            return false;
        }
    }

    public static I As<I>() where I : class
    {
        if (!typeof(I).IsInterface)
        {
            throw new ArgumentException("I must be an interface type.");
        }
        
        return new Log<T>(new T()).ActLike<I>();
    }

    public string Info
    {
        get
        {
            var sb = new StringBuilder();
            foreach (var methodCallCount in _methodCallCounts)
            {
                sb.AppendLine($"{methodCallCount.Key} called {methodCallCount.Value} time(s).");
            }
            
            return sb.ToString();
        }
    }
    
    public override string ToString()
    {
        return $"{Info}\n{_subject}";
    }
}