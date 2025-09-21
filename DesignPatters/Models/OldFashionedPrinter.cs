namespace DesignPatters.Models;

public class OldFashionedPrinter : IMachine
{
    public void Print()
    {
        Console.WriteLine("Printing");
    }

    public void Scan()
    {
        throw new NotImplementedException();
    }

    public void Fax()
    {
        throw new NotImplementedException();
    }
}