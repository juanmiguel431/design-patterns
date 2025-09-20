
using System.Diagnostics;
using DesignPatters.Models;

namespace DesignPatters;

class Program
{
    static void Main(string[] args)
    {
        // Single Responsibility Principle
        // CreateAndOpenJournalFile();
        
        // Open Closed Principle
        CreateAndFilterProducts();


        Console.WriteLine("Green products (old): ");

        Console.WriteLine("End");
    }

    private static void CreateAndFilterProducts()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);
        
        var products = new [] { apple, tree, house };
        
        var filter = new ProductFilter();

        foreach (var product in filter.FilterByColor(products, Color.Green))
        {
            Console.WriteLine($" - {product.Name} is Green");
        }
    }

    private static void CreateAndOpenJournalFile()
    {
        var journal = new Journal();
        journal.AddEntry("I cried today.");
        journal.AddEntry("I ate a banana.");
        
        var persistence = new Persistence();
        
        var tempPath = Path.GetTempPath();
        var fileName = tempPath + "journal.txt";
        persistence.SaveToFile(journal, fileName, true);

        var psi = new ProcessStartInfo
        {
            FileName = fileName,
            UseShellExecute = true
        };
        
        Process.Start(psi);
    }
}