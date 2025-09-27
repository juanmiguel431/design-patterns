namespace DesignPatters.Models.Singleton;

public sealed class BuildingContext : IDisposable
{
    public int WallHeight { get; set; }
    
    private static readonly Stack<BuildingContext> Stack;
    public static BuildingContext Current => Stack.Peek();

    static BuildingContext()
    {
        Stack = new Stack<BuildingContext>();
    }

    public BuildingContext(int wallHeight)
    {
        WallHeight = wallHeight;
        Stack.Push(this);
    }
    
    public void Dispose()
    {
        Stack.Pop();
    }
}