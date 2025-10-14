namespace DesignPatters.Models.Memento;

public class MementoEx
{
    public List<TokenEx> Tokens { get; } = [];
    
    public MementoEx(List<TokenEx> tokens)
    {
        Tokens.AddRange(tokens);
    }
}