namespace DesignPatters.Models.Interpreter;

public class Token
{
    public Type MyType { get; set; }
    public string Text { get; set; }
    
    public Token(Type myType, string text)
    {
        Text = text ?? throw new ArgumentNullException(nameof(text));
        MyType = myType;
    }

    public enum Type
    {
        Integer, Plus, Minus, Lparen, Rparen,
    }

    public override string ToString()
    {
        return $"`{Text}`";
    }
    

}