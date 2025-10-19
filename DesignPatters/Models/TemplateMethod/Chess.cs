namespace DesignPatters.Models.TemplateMethod;

public class Chess : Game
{
    public Chess() : base(2)
    {
    }

    public override void Start()
    {
        Console.WriteLine($"Starting a new game of chess with {_numberOfPlayers} players.");
    }

    protected override void TakeTurn()
    {
        Console.WriteLine($"Turn {_turn++} taken by player {_currentPlayer}.");
        _currentPlayer = (_currentPlayer + 1) % _numberOfPlayers;
    }

    protected override bool HaveWinner => _turn == _maxTurns;
    protected override int WinningPlayer => _currentPlayer;

    private int _turn = 1;
    private int _maxTurns = 10;
}