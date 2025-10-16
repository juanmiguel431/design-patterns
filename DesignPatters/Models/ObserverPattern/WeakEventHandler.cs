using System.Reflection;

namespace DesignPatters.Models.ObserverPattern;

public class WeakEventHandler<TEventArgs>
{
    private readonly WeakReference _targetRef;
    private readonly MethodInfo _method;

    public WeakEventHandler(EventHandler<TEventArgs> handler)
    {
        _targetRef = new WeakReference(handler.Target);
        _method = handler.Method;
    }

    public void Handler(object? sender, TEventArgs e)
    {
        var target = _targetRef.Target;
        if (target is not null)
        {
            _method.Invoke(target, [sender, e]);
        }
        else
        {
            Console.WriteLine("Target has been collected; handler skipped.");
        }
    }
}