namespace DesignPatters.Models.TemplateMethod;

public abstract class Game
{
    public void Run()
    {
        Start();
        while (!HaveWinner)
        {
            TakeTurn();
        }

        Console.WriteLine($"Player {WinningPlayer} wins!");
    }
    
    public abstract void Start();
    protected int _currentPlayer;
    protected readonly int _numberOfPlayers;

    protected Game(int numberOfPlayers)
    {
        _numberOfPlayers = numberOfPlayers;
    }
    
    protected abstract void TakeTurn();
    protected abstract bool HaveWinner { get; }
    protected abstract int WinningPlayer { get; }
}