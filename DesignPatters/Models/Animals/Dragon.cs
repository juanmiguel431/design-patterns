namespace DesignPatters.Models.Animals;

public class Dragon: IBird, ILizard
{
    private readonly Bird _bird = new Bird();
    private readonly Lizard _lizard = new Lizard();
    private int _weight;
    
    public int Weight
    {
        get => _weight;
        set
        {
            _weight = value;
            _bird.Weight = value;
            _lizard.Weight = value;
        }
    }

    public void Fly()
    {
        _bird.Fly();
    }

    public void Crawl()
    {
        _lizard.Crawl();
    }
}