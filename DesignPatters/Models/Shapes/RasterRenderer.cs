namespace DesignPatters.Models.Shapes;

public class RasterRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing pixels for a circle with radius: {radius}");
    }
}