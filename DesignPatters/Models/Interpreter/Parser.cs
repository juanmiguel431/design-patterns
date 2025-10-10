namespace DesignPatters.Models.Interpreter;

public class Parser
{
    public static IElement Parse(IReadOnlyList<Token> tokens)
    {
        var result = new BinaryOperation();
        var haveLhs = false;
        for (var i = 0; i < tokens.Count; i++)
        {
            var  token = tokens[i];
            switch (token.MyType)
            {
                case Token.Type.Integer:
                    var integer = new Integer(int.Parse(token.Text));
                    if (!haveLhs)
                    {
                        result.Left = integer;
                        haveLhs = true;
                    }
                    else
                    {
                        result.Right = integer;
                    }
                    break;
                case Token.Type.Plus:
                    result.MyType = BinaryOperation.Type.Addition;
                    break;
                case Token.Type.Minus:
                    result.MyType = BinaryOperation.Type.Subtraction;
                    break;
                case Token.Type.Lparen:
                    var j = i;
                    for (; j < tokens.Count; j++)
                    {
                        if (tokens[j].MyType == Token.Type.Rparen)
                        {
                            break; // found it!
                        }
                    }
                    
                    // process subexpression w/o opening (
                    var subexpression = tokens.Skip(i + 1).Take(j - i - 1).ToList();
                    var element = Parse(subexpression);
                    
                    if (!haveLhs)
                    {
                        result.Left = element;
                        haveLhs = true;
                    }
                    else
                    {
                        result.Right = element;
                    }
                    
                    i = j; // advance
                    
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        return result;
    }
}