using System.Diagnostics;
using System.Text;
using DesignPatters.Filters;
using DesignPatters.Models;
using DesignPatters.Specifications;
using DesignPatters.Specifications.ProductSpecifications;

namespace DesignPatters;

class Program
{
    static void Main(string[] args)
    {
        // Single Responsibility Principle
        // CreateAndOpenJournalFile();

        // Open Closed Principle
        // CreateAndFilterProducts();
        
        // Liskov Substitution Principle
        // ShapesAreaCalculation();
        
        // Interface Segregation Principle
        // OldFashionedPrinter();
        
        // Dependency Inversion Principle
        // CreateRelationshipsForResearch();

        // Builder Pattern
        // GenerateHtmlOutput();
        // var personJobBuilder = new EmployeeBuilder();
        // personJobBuilder.SetFirstName("Juan Miguel");
        // CreateAndDisplayPersonAndEmployee();

        // Stepwise Builder
        // StepwiseBuilder();

        // Functional Builder
        // FunctionalBuilder();
        
        // Faceted Builder
        CreatePersonWithFacetedBuilder();


        Console.WriteLine("End");
    }

    private static void CreatePersonWithFacetedBuilder()
    {
        var person = Person.PersonFacetedBuilder()
            .SetFirstName("Juan")
            .SetMiddleName("Miguel")
            .SetLastName("Paulino Carpio")
            .Location
                .SetLatitude(1.5f)
                .SetLongitude(-15.2f)
            .Address
                .SetStreet("1822 Seward Ave.")
                .SetCity("Bronx")
                .SetState("New York")
                .SetZipCode("10473")
            .Build();
        
        Console.WriteLine(person);
    }

    private static void FunctionalBuilder()
    {
        var person = Person.FunctionalBuilder()
            .SetFirstName("Juan")
            .SetMiddleName("Miguel")
            .SetLastName("Paulino Carpio")
            .Build();
        
        Console.WriteLine(person);

        var employee = Employee.FunctionalBuilder()
            .SetFirstName("Juan")
            .SetMiddleName("Miguel")
            .SetLastName("Paulino Carpio")
            .SetCompany("Company")
            .SetPosition("Developer")
            .Build();

        Console.WriteLine(employee);
    }

    private static void StepwiseBuilder()
    {
        var car = Car.Builder()
            .OfType(CarType.Sedan)
            .WheelSize(15)
            .Build();

        Console.WriteLine(car);
    }

    private static void CreateAndDisplayPersonAndEmployee()
    {
        var person = Person.Builder()
            .SetFirstName("Juan")
            .SetMiddleName("Miguel")
            .SetLastName("Paulino Carpio")
            .Build();

        Console.WriteLine(person);
        
        var employee = Employee.Builder()
            .SetFirstName("Juan")
            .SetPosition("Software Engineer")
            .SetMiddleName("Miguel")
            .SetLastName("Paulino Carpio")
            .SetCompany("Company")
            .Build();

        Console.WriteLine(employee);
    }

    private static void GenerateHtmlOutput()
    {
        var hello = "Hello";
        var sb = new StringBuilder();
        sb.Append("<b>");
        sb.Append(hello);
        sb.Append("</b>");
        Console.WriteLine(sb);

        var words = new [] {"Hello", "World"};
        sb.Clear();
        sb.Append("<ul>");
        foreach (var word in words)
        {
            sb.AppendFormat("<li>{0}</li>", word);
        }
        sb.Append("</ul>");
        Console.WriteLine(sb);

        var root = new HtmlBuilder("html");
        var body = root.AddChild("body");
        body.AddChild("h1", "Hello World");
        body.AddChild("p", "This is a paragraph");
        var li = body.AddChild("ul");
        li.AddChild("li", "Hello");
        li.AddChild("li", "World");
        Console.WriteLine(root);
    }

    private static void CreateRelationshipsForResearch()
    {
        var parent = new Person() { FirstName = "John" };
        var child1 = new Person() { FirstName = "Chris" };
        var child2 = new Person() { FirstName = "Mary" };
        
        var relationships = new Relationships();
        relationships.AddParentAndChild(parent, child1);
        relationships.AddParentAndChild(parent, child2);
        
        var research = new Research(relationships);
        research.PrintAllChildrenOf("John");
    }

    private static void OldFashionedPrinter()
    {
        var oldFashionedPrinter = new OldFashionedPrinter();
        oldFashionedPrinter.Print(); // It can only print
    }

    private static void ShapesAreaCalculation()
    {
        var rec = new Rectangle()
        {
            Height = 3,
            Width = 6,
        };
        Console.WriteLine($"{rec} has area {rec.GetArea()}");

        Shape sq = new Square()
        {
            Side = 5
        };
        
        Console.WriteLine($"{sq} has area {sq.GetArea()}");
    }

    private static void CreateAndFilterProducts()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);

        var products = new[] { apple, tree, house };

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

        Console.WriteLine("Large Blue products:");
        foreach (var product in betterFilter.Filter(
                     products,
                     new AndSpecification<Product>(
                         new SizeSpecification(Size.Large),
                         new ColorSpecification(Color.Blue)
                     )))
        {
            Console.WriteLine($" - {product.Name} is Large and Blue");
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