namespace DesignPatters.Models.Singleton;

public class PerThreadSingleton
{
    private static readonly ThreadLocal<PerThreadSingleton> ThreadInstance = new(() => new PerThreadSingleton());
    
    public static PerThreadSingleton Instance => ThreadInstance.Value;

    public int Id;
    
    private PerThreadSingleton()
    {
        Id = Environment.CurrentManagedThreadId;
    }
}