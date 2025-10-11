namespace DesignPatters.Models.Interpreter;

public class BinaryOperation : IElement
{
    public enum Type
    {
        Addition, Subtraction
    }

    public BinaryOperation(IElement left, IElement right, Type myType)
    {
        Left = left;
        Right = right;
        MyType = myType;
    }

    public BinaryOperation()
    {
    }

    public int Value
    {
        get
        {
            switch (MyType)
            {
                case Type.Addition:
                    return Left.Value + Right.Value;
                case Type.Subtraction:
                    return Left.Value - Right.Value;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    public Type MyType { get; set; }
    public IElement Left { get; set; }
    public IElement Right { get; set; }
}