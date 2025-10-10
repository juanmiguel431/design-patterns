using System.Text;

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
    
    public static List<Token> Lex(string input)
    {
        var result = new List<Token>();
        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case '+':
                    result.Add(new Token(Token.Type.Plus, "+"));
                    break;
                case '-':
                    result.Add(new Token(Token.Type.Minus, "-"));
                    break;
                case '(':
                    result.Add(new Token(Token.Type.Lparen, "("));
                    break;
                case ')':
                    result.Add(new Token(Token.Type.Rparen, ")"));
                    break;
                default:
                    var sb = new StringBuilder(input[i].ToString());
                    for (var j = 0; j < input.Length; j++)
                    {
                        if (char.IsDigit(input[j]))
                        {
                            sb.Append(input[j]);
                            i++;
                        }
                        else
                        {
                            result.Add(new Token(Token.Type.Integer, sb.ToString()));
                            break;
                        }
                    }
                    break;
            }
        }
        
        return result;
    }
}