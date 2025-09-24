namespace DesignPatters.Models;

public class Foo
{
    private Foo()
    {
        
    }
    
    private async Task<Foo> InitAsync()
    {
        await Task.Delay(1000);
        return this;
    }

    public static async Task<Foo> CreateAsync()
    {
        var food = new Foo();
        await food.InitAsync();
        return food;
    }
}