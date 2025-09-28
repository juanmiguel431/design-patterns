namespace DesignPatters.Models.Shapes;

public class Circle : Figure
{
    private float _radius;
    
    public Circle(IRenderer renderer, float radius) : base(renderer)
    {
        _radius = radius;
    }

    public override void Draw()
    {
        Renderer.RenderCircle(_radius);
    }

    public override void Resize(float factor)
    {
        _radius *= factor;
    }
}