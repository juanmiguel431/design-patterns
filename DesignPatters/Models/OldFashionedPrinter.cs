namespace DesignPatters.Models;

public class OldFashionedPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing");
    }
}