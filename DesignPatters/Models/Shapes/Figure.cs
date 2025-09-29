namespace DesignPatters.Models.Shapes;

public abstract class Figure: IFigure
{
    protected readonly IRenderer Renderer;

    protected Figure(IRenderer renderer)
    {
        Renderer = renderer;
    }
    
    public abstract void Draw();
    public abstract void Resize(float factor);
}

public interface IFigure
{
    void Draw();
}

public class FigureGroup : IFigure
{
    private readonly Lazy<List<IFigure>> _figures = new();
    public List<IFigure> Children => _figures.Value;
    
    public void Add(IFigure figure)
    {
        Children.Add(figure);
    }
    
    public void Draw()
    {
        foreach (var figure in Children)
        {
            figure.Draw();
        }
    }
}