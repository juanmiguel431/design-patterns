namespace DesignPatters.Models.Visitor;

public abstract class ExpressionVisitorE
{
    public abstract void Visit(ValueE value);
    public abstract void Visit(AdditionExpressionE ae);
    public abstract void Visit(MultiplicationExpressionE me);
}

// Visitor Coding Exercise
//     You are asked to implement a double-dispatch visitor called ExpressionPrinter  for printing different mathematical expressions. 
//     The range of expressions covers addition and multiplication - 
//     please put round brackets around addition operations (but not multiplication ones)! 
//     Also, please avoid any blank spaces in output.
//
//     Example:
//
// Input: AdditionExpression(Literal(2), Literal(3)) 
//
// Output: (2+3) 