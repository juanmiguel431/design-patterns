namespace DesignPatters.Models.Printers;

public class OldFashionedPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing");
    }
}