namespace DesignPatters.Models.ObserverPattern;

public class RatGame
{
    public event EventHandler<int>? OnRatCountsChange;

    public void NotifyObservers()
    {
        var total = OnRatCountsChange?.GetInvocationList().Length ?? 0;
        OnRatCountsChange?.Invoke(this, total);
    }
}

// Imagine a game where one or more rats can attack a player. Each individual rat has an Attack value of 1. However, rats attack as a swarm, so each rat's Attack value is equal to the total number of rats in play.
//
//     Given that a rat enters play through the constructor and leaves play (dies) via its Dispose() method, please implement the Game and Rat classes so that, at any point in the game, the Attack value of a rat is always consistent.
//
// This exercise has two simple rules:
//
// The Game class cannot have properties or fields. It can only contain events and methods.
//     The Rat class' Attack field is strictly a field, not a property.