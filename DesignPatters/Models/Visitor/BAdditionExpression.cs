namespace DesignPatters.Models.Visitor;

public class BAdditionExpression : BExpression
{
    public BExpression Left { get; }
    public BExpression Right { get; }
    
    public BAdditionExpression(BExpression left, BExpression right)
    {
        Left = left;
        Right = right;
    }
}