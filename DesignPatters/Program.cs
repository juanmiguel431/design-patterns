
using System.Diagnostics;
using DesignPatters.Models;

namespace DesignPatters;

public interface ISpecification<in T>
{
    bool IsSatisfiedBy(T item);
}

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}


public class ColorSpecification : ISpecification<Product>
{
    private readonly Color _color;

    public ColorSpecification(Color color)
    {
        _color = color;
    }
    
    public bool IsSatisfiedBy(Product item)
    {
        return item.Color == _color;
    }
}

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach (var item in items)
        {
            if (spec.IsSatisfiedBy(item))
            {
                yield return item;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Single Responsibility Principle
        // CreateAndOpenJournalFile();
        
        // Open Closed Principle
        CreateAndFilterProducts();
        
        Console.WriteLine("End");
    }

    private static void CreateAndFilterProducts()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);
        
        var products = new [] { apple, tree, house };
        
        var filter = new ProductFilter();
        Console.WriteLine("Green products (old):");
        foreach (var product in filter.FilterByColor(products, Color.Green))
        {
            Console.WriteLine($" - {product.Name} is Green");
        }
        
        
        var betterFilter = new BetterFilter();
        var greenProducts = betterFilter.Filter(products, new ColorSpecification(Color.Green));
        Console.WriteLine("Green products (new):");
        foreach (var product in greenProducts)
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