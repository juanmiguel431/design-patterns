using System.Text;

namespace DesignPatters.Models.Interpreter;

public class ExpressionProcessor
{
    public Dictionary<char, int> Variables = new Dictionary<char, int>();

    public int Calculate(string expression)
    {
        var tokens = Expression.Lex(expression);
        var result = Parser(tokens);
        
        return result.Value;
    }
    
    private IElement Parser(List<ExpressionToken> tokens)
    {
        var variables = tokens.Where(t => t.TheType == ExpressionToken.Type.Variable).ToList();

        var noExistingVariables = variables.Any(p => Variables.All(v => v.Key != char.Parse(p.Text)));
        if (noExistingVariables || ExistsContiguousVariables(tokens)) return new Integer(0);

        BinaryOperation result = null;
        IElement? lhs = null;
        IElement? rhs = null;
        BinaryOperation.Type? operation = null;
        for (var i = 0; i < tokens.Count; i++)
        {
            var  token = tokens[i];
            switch (token.TheType)
            {
                case ExpressionToken.Type.Number:
                {
                    var integer = new Integer(int.Parse(token.Text));
                    if (lhs is null)
                    {
                        lhs = integer;
                    }
                    else
                    {
                        rhs = integer;
                    }

                    break;
                }
                case ExpressionToken.Type.Plus:
                    operation = BinaryOperation.Type.Addition;
                    break;
                case ExpressionToken.Type.Minus:
                    operation = BinaryOperation.Type.Subtraction;
                    break;
                case ExpressionToken.Type.Variable:
                {
                    var varValue = Variables[char.Parse(token.Text)];
                    var integer = new Integer(varValue);
                    if (lhs is null)
                    {
                        lhs = integer;
                    }
                    else
                    {
                        rhs = integer;
                    }

                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            if (rhs is not null && operation is not null)
            {
                if (result is null)
                {
                    result = new BinaryOperation(lhs, rhs, operation.Value);
                }
                else
                {
                    result = new BinaryOperation(result, rhs, operation.Value);
                }
                
                rhs = null;
                operation = null;
            }
        }

        if (result is null && lhs is null)
        {
            return new Integer(0);
        }
        
        if (result is null && lhs is not null)
        {
            return lhs;
        }
        
        return result;
    }

    private static bool ExistsContiguousVariables(List<ExpressionToken> tokens)
    {
        for (var index = 0; index < tokens.Count; index++)
        {
            var currentToken = tokens[index];

            if (currentToken.TheType != ExpressionToken.Type.Variable) continue;
            
            var next = index + 1;
            if (next < tokens.Count && tokens[next].TheType == ExpressionToken.Type.Variable)
            {
                return true;
            }
        }

        return false;
    }
}

public class Expression
{
    public static List<ExpressionToken> Lex(string expression)
    {
        var result = new List<ExpressionToken>();
        for (var index = 0; index < expression.Length; index++)
        {
            var character1 = expression[index];
            switch (character1)
            {
                case '+':
                    result.Add(new ExpressionToken(ExpressionToken.Type.Plus, "+"));
                    break;
                case '-':
                    result.Add(new ExpressionToken(ExpressionToken.Type.Minus, "-"));
                    break;
                default:
                    if (char.IsLetter(character1))
                    {
                        result.Add(new ExpressionToken(ExpressionToken.Type.Variable, character1.ToString()));
                        break;
                    }
                    
                    var sb = new StringBuilder(character1.ToString());
                    for (var j = index + 1; j < expression.Length; j++)
                    {
                        var character2 = expression[j];
                        if (char.IsDigit(character2))
                        {
                            sb.Append(character2);
                            index++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                    result.Add(new ExpressionToken(ExpressionToken.Type.Number, sb.ToString()));
                    break;
            }
        }

        return result;
    }
}

public class ExpressionToken
{
    public Type TheType { get; private set; }
    public string Text { get; }

    public ExpressionToken(Type theType, string text)
    {
        TheType = theType;
        Text = text;
    }

    public enum Type { Number, Variable, Plus, Minus }
    
    public override string ToString() => $"`{Text}`";
}


// You are asked to write an expression processor for simple numeric expressions with the following constraints:
//
// Expressions use integral values (e.g., '13' ), single-letter variables defined in Variables, as well as + and - operators only
// There is no need to support braces or any other operations
//     If a variable is not found in Variables  (or if we encounter a variable with >1 letter, e.g. ab), the evaluator returns 0 (zero)
// In case of any parsing failure, evaluator returns 0
// Example:
//
// Calculate("1+2+3")  should return 6
// Calculate("1+2+xy")  should return 0
// Calculate("10-2-x")  when x=3 is in Variables  should return 5