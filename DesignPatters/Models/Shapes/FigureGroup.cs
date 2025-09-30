namespace DesignPatters.Models.Shapes;

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