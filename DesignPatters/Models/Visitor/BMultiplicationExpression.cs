namespace DesignPatters.Models.Visitor;

public class BMultiplicationExpression : BExpression
{
    public BExpression Left { get; }
    public BExpression Right { get; }
    
    public BMultiplicationExpression(BExpression left, BExpression right)
    {
        Left = left;
        Right = right;
    }
}