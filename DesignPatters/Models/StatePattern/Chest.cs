namespace DesignPatters.Models.StatePattern;

public enum Chest
{
    Open, Closed, Locked,
}

public enum ChestAction
{
    Open, Close
}

public class ChestDemo
{
    public static Chest Manipulate(Chest chest, ChestAction action, bool haveKey)
    {
        return (chest, action, haveKey) switch
        {
            (Chest.Locked, ChestAction.Open, true) => Chest.Open,
            (Chest.Closed, ChestAction.Open, _) => Chest.Open,
            (Chest.Open, ChestAction.Close, true) => Chest.Locked,
            (Chest.Open, ChestAction.Close, false) => Chest.Closed,
            _ => chest
        };
    }
    
    public static Chest Manipulate2(Chest chest, ChestAction chestAction, bool haveKey)
    {
        switch (chest, action: chestAction, haveKey)
        {
            case (Chest.Locked, ChestAction.Open, true):
            case (Chest.Closed, ChestAction.Open, _):
                return Chest.Open;
            case (Chest.Open, ChestAction.Close, true):
                return Chest.Locked;
            case (Chest.Open, ChestAction.Close, false):
                return Chest.Closed;
            default:
                Console.WriteLine("Chest is already in this state");
                return chest;
        }
    }
}