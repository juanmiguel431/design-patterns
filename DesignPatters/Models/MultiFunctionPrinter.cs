namespace DesignPatters.Models;

public class MultiFunctionPrinter : IMultifunctionDevice
{
    public void Print()
    {
        Console.WriteLine("Printing");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning");
    }

    public void Fax()
    {
        Console.WriteLine("Faxing");
    }
}