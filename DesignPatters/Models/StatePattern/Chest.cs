namespace DesignPatters.Models.StatePattern;

public enum Chest
{
    Open, Closed, Locked,
}

public enum Action
{
    Open, Close
}

public class Demo
{
    public static Chest Manipulate(Chest chest, Action action, bool haveKey)
    {
        return (chest, action, haveKey) switch
        {
            (Chest.Locked, Action.Open, true) => Chest.Open,
            (Chest.Closed, Action.Open, _) => Chest.Open,
            (Chest.Open, Action.Close, true) => Chest.Locked,
            (Chest.Open, Action.Close, false) => Chest.Closed,
            _ => chest
        };
    }
    
    public static Chest Manipulate2(Chest chest, Action action, bool haveKey)
    {
        switch (chest, action, haveKey)
        {
            case (Chest.Locked, Action.Open, true):
            case (Chest.Closed, Action.Open, _):
                return Chest.Open;
            case (Chest.Open, Action.Close, true):
                return Chest.Locked;
            case (Chest.Open, Action.Close, false):
                return Chest.Closed;
            default:
                Console.WriteLine("Chest is already in this state");
                return chest;
        }
    }
}