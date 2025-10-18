namespace DesignPatters.Models.ObserverPattern;

public class Rat : IDisposable
{
    private readonly RatGame _game;
    public int Attack = 1;

    public Rat(RatGame game)
    {
        _game = game;
        game.OnRatCountsChange += UpdateAttack;
        game.NotifyObservers();
    }

    private void UpdateAttack(object? sender, int total)
    {
        Attack = total;
    }

    public void Dispose()
    {
        _game.OnRatCountsChange -= UpdateAttack;
        _game.NotifyObservers();
    }
}