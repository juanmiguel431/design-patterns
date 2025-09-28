namespace DesignPatters.Models.Shapes;

public abstract class Figure
{
    protected readonly IRenderer Renderer;

    protected Figure(IRenderer renderer)
    {
        Renderer = renderer;
    }
    
    public abstract void Draw();
    public abstract void Resize(float factor);
}