namespace DesignPatters.Models.Shapes;

public class VectorRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing a circle with radius: {radius}");
    }
}