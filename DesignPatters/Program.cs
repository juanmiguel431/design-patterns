using System.Diagnostics;
using System.Text;
using DesignPatters.Filters;
using DesignPatters.Models;
using DesignPatters.Models.Cars;
using DesignPatters.Models.Drinks;
using DesignPatters.Models.Html;
using DesignPatters.Models.Journals;
using DesignPatters.Models.Persons;
using DesignPatters.Models.Persons.Employees;
using DesignPatters.Models.Persons.Relations;
using DesignPatters.Models.Points;
using DesignPatters.Models.Printers;
using DesignPatters.Models.Products;
using DesignPatters.Models.Shapes;
using DesignPatters.Models.Themes;
using DesignPatters.Specifications;
using DesignPatters.Specifications.ProductSpecifications;

namespace DesignPatters;

class Program
{
    public static async Task Main(string[] args)
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
        // CreatePersonWithFacetedBuilder();

        // Builder Pattern Exercise
        // BuilderPatternExercise();

        // Factory Pattern
        // FactoryPattern();
        
        // Asynchronous Factory Method
        // var foo = await Foo.CreateAsync();

        // Class Factory Pattern
        // ClassFactoryPattern();
        
        // Object tracking with Factory Method
        // GenerateThemesWithFactory();

        // Bulk Replacement with Factory Class
        // BulkReplacementWithFactoryClass();

        // Abstract Factory Pattern
        // AbstractFactoryPattern();

        // Prototype Pattern - The problem
        // PrototypePatternTheProblem();
        
        // Prototype Pattern - Copy constructor
        // CopyConstructor();
        
        // Prototype Pattern - Clone method
        // DeepCopyMethod();
        
        // Prototype Pattern - Inheritance - Copy constructor
        // DeepCopyAndInheritanceWithCopyConstructor();

        // Prototype Pattern - Inheritance - Clone method
        // DeepCopyWithInterface();
        
        // Prototype Pattern - Serialization
        // DeepCopyWithJsonSerialization();
        
        DeepCopyWithXmlSerialization();
        
        Console.WriteLine("End");
    }
    
    private static void DeepCopyWithXmlSerialization()
    {
        var employee1 = new Employee()
        {
            FirstName = "Juan",
            MiddleName = "Miguel",
            LastName = "Paulino Carpio",
            Position = "Software Engineer",
            Company = "Company",
            Salary = 1000000,
            Responsibilities = ["Develop", "Test"],
            Nicknames = ["juanmiguel431", "carpio"],
            Street = "Amparo Decena",
            City = "Villa Carmen",
            State = "Santo Domingo Este",
            ZipCode = "10473",
            Latitude = 123,
            Longitude = 456,
            ContactInfo = new ()
            {
                Email = "juanmiguel431@gmail.com",
                Phone = "8298205436",
                Facebook = "juanmiguel431"
            }
        };
        
        var employee2 = employee1.CloneWithXml();
        
        employee2.FirstName = "Oscar";
        employee2.MiddleName = "Ivan";
        employee2.LastName = "Polanco";
        employee2.Street = "Doña Emma Balaguer";
        employee2.City = "Villa Carmen";
        employee2.State = "Santo Domingo Este";
        employee2.ZipCode = "10473";
        employee2.Latitude = 963;
        employee2.Longitude = 852;
        employee2.Company = "Altice";
        employee2.Salary = 45000;
        employee2.Position = "Seller";
        employee2.Responsibilities[0] = "Sell";
        employee2.Responsibilities[1] = "Bey";
        employee2.Nicknames[0] = "ivanpolanco";
        employee2.Nicknames[1] = "polanco";
        employee2.ContactInfo.Email = "ivanpolanco@gmail.com";
        employee2.ContactInfo.Facebook = "ivanpolanco";

        Console.WriteLine(employee1);
        Console.WriteLine(employee2);
    }
    
    private static void DeepCopyWithJsonSerialization()
    {
        var employee1 = new Employee()
        {
            FirstName = "Juan",
            MiddleName = "Miguel",
            LastName = "Paulino Carpio",
            Position = "Software Engineer",
            Company = "Company",
            Salary = 1000000,
            Responsibilities = ["Develop", "Test"],
            Nicknames = ["juanmiguel431", "carpio"],
            Street = "Amparo Decena",
            City = "Villa Carmen",
            State = "Santo Domingo Este",
            ZipCode = "10473",
            Latitude = 123,
            Longitude = 456,
            ContactInfo = new ()
            {
                Email = "juanmiguel431@gmail.com",
                Phone = "8298205436",
                Facebook = "juanmiguel431"
            }
        };
        
        var employee2 = employee1.CloneWithSerialization();
        
        employee2.FirstName = "Oscar";
        employee2.MiddleName = "Ivan";
        employee2.LastName = "Polanco";
        employee2.Street = "Doña Emma Balaguer";
        employee2.City = "Villa Carmen";
        employee2.State = "Santo Domingo Este";
        employee2.ZipCode = "10473";
        employee2.Latitude = 963;
        employee2.Longitude = 852;
        employee2.Company = "Altice";
        employee2.Salary = 45000;
        employee2.Position = "Seller";
        employee2.Responsibilities[0] = "Sell";
        employee2.Responsibilities[1] = "Bey";
        employee2.Nicknames[0] = "ivanpolanco";
        employee2.Nicknames[1] = "polanco";
        employee2.ContactInfo.Email = "ivanpolanco@gmail.com";
        employee2.ContactInfo.Facebook = "ivanpolanco";

        Console.WriteLine(employee1);
        Console.WriteLine(employee2);
    }
    
    private static void DeepCopyWithInterface()
    {
        var employee1 = new Employee()
        {
            FirstName = "Juan",
            MiddleName = "Miguel",
            LastName = "Paulino Carpio",
            Position = "Software Engineer",
            Company = "Company",
            Salary = 1000000,
            Responsibilities = ["Develop", "Test"],
            Nicknames = ["juanmiguel431", "carpio"],
            Street = "Amparo Decena",
            City = "Villa Carmen",
            State = "Santo Domingo Este",
            ZipCode = "10473",
            Latitude = 123,
            Longitude = 456,
            ContactInfo = new ()
            {
                Email = "juanmiguel431@gmail.com",
                Phone = "8298205436",
                Facebook = "juanmiguel431"
            }
        };
        
        var employee2 = employee1.DeepClone();
        var person2 = employee1.DeepClone<Person>();
        person2.FirstName = "Antonia";
        person2.MiddleName = "";
        person2.LastName = "Carpio";
        person2.Street = "Street";
        person2.City = "City";
        person2.State = "State";
        person2.ZipCode = "ZipCode";
        person2.Latitude = 1;
        person2.Longitude = 2;
        person2.Nicknames[0] = "antonia";
        person2.Nicknames[1] = "carpio";
        person2.ContactInfo.Email = "antonia@gmail.com";
        person2.ContactInfo.Facebook = "antonia";
        
        employee2.FirstName = "Oscar";
        employee2.MiddleName = "Ivan";
        employee2.LastName = "Polanco";
        employee2.Street = "Doña Emma Balaguer";
        employee2.City = "Villa Carmen";
        employee2.State = "Santo Domingo Este";
        employee2.ZipCode = "10473";
        employee2.Latitude = 963;
        employee2.Longitude = 852;
        employee2.Company = "Altice";
        employee2.Salary = 45000;
        employee2.Position = "Seller";
        employee2.Responsibilities[0] = "Sell";
        employee2.Responsibilities[1] = "Bey";
        employee2.Nicknames[0] = "ivanpolanco";
        employee2.Nicknames[1] = "polanco";
        employee2.ContactInfo.Email = "ivanpolanco@gmail.com";
        employee2.ContactInfo.Facebook = "ivanpolanco";

        Console.WriteLine(employee1);
        Console.WriteLine(employee2);
        Console.WriteLine(person2);
    }

    private static void DeepCopyAndInheritanceWithCopyConstructor()
    {
        var employee1 = new Employee()
        {
            FirstName = "Juan",
            MiddleName = "Miguel",
            LastName = "Paulino Carpio",
            Position = "Software Engineer",
            Company = "Company",
            Salary = 1000000,
            Responsibilities = ["Develop", "Test"],
            Nicknames = ["juanmiguel431", "carpio"],
            Street = "Amparo Decena",
            City = "Villa Carmen",
            State = "Santo Domingo Este",
            ZipCode = "10473",
            Latitude = 123,
            Longitude = 456,
            ContactInfo = new ()
            {
                Email = "juanmiguel431@gmail.com",
                Phone = "8298205436",
                Facebook = "juanmiguel431"
            }
        };
        
        var employee2 = employee1.DeepCopy();
        employee2.FirstName = "Oscar";
        employee2.MiddleName = "Ivan";
        employee2.LastName = "Polanco";
        employee2.Street = "Doña Emma Balaguer";
        employee2.City = "Villa Carmen";
        employee2.State = "Santo Domingo Este";
        employee2.ZipCode = "10473";
        employee2.Latitude = 963;
        employee2.Longitude = 852;
        employee2.Company = "Altice";
        employee2.Salary = 45000;
        employee2.Position = "Seller";
        employee2.Responsibilities[0] = "Sell";
        employee2.Responsibilities[1] = "Bey";
        employee2.Nicknames[0] = "ivanpolanco";
        employee2.Nicknames[1] = "polanco";
        employee2.ContactInfo.Email = "ivanpolanco@gmail.com";
        employee2.ContactInfo.Facebook = "ivanpolanco";
        

        Console.WriteLine(employee1);
        Console.WriteLine(employee2);
    }

    private static void DeepCopyMethod()
    {
        var person1 = new Person("Juan Miguel", "Paulino Carpio", new ContactInfo("juanmiguel431@gmail.com", "8298205436", "juanmiguel431"));
        var person2 = person1.DeepCopy();
        person2.FirstName = "Luigi";
        person2.ContactInfo.Email = "luimiguel424@gmail.com";
        person2.ContactInfo.Phone = "809256619";
        person2.ContactInfo.Facebook = "luimiguel424";
        
        Console.WriteLine(person1);
        Console.WriteLine(person2);
    }

    private static void CopyConstructor()
    {
        var person1 = new Person("Juan Miguel", "Paulino Carpio", new ContactInfo("juanmiguel431@gmail.com", "8298205436", "juanmiguel431"));
        var person2 = new Person(person1);
        person2.FirstName = "Luigi";
        person2.ContactInfo.Email = "luimiguel424@gmail.com";
        person2.ContactInfo.Phone = "809256619";
        person2.ContactInfo.Facebook = "luimiguel424";
        
        Console.WriteLine(person1);
        Console.WriteLine(person2);
    }

    private static void PrototypePatternTheProblem()
    {
        var person1 = new Person("Juan Miguel", "Paulino Carpio", new ContactInfo("juanmiguel431@gmail.com", "8298205436", "juanmiguel431"));
        
        var person2 = person1.Clone() as Person;
        person2.FirstName = "Luigi";
        person2.ContactInfo.Email = "luimiguel424@gmail.com";
        person2.ContactInfo.Phone = "809256619";
        
        Console.WriteLine(person1);
        Console.WriteLine(person2);
    }

    private static void AbstractFactoryPattern()
    {
        var hotDrinkMachine = new HotDrinkMachine();
        var hotDrink = hotDrinkMachine.MakeDrink(DrinkType.Coffee, 100);
        hotDrink.Consume();
    }

    private static void BulkReplacementWithFactoryClass()
    {
        var factory2 = new ReplaceableThemeFactory();
        var magicTheme = factory2.CreateTheme(true);
        Console.WriteLine(magicTheme.Value.BrgColor);
        factory2.ReplaceTheme(false);
        Console.WriteLine(magicTheme.Value.BrgColor);
    }

    private static void GenerateThemesWithFactory()
    {
        var factory = new TrackingThemeFactory();
        var theme1 = factory.CreateTheme(false);
        var theme2 = factory.CreateTheme(true);

        Console.WriteLine(factory.Info);
    }

    private static void ClassFactoryPattern()
    {
        var point = Point.Factory.CreateNewPolarPoint(1.0, Math.PI / 2);

        Console.WriteLine(point);
    }
    
    private static void FactoryPattern()
    {
        var point = Point.Factory.CreateNewPolarPoint(1.0, Math.PI / 2);

        Console.WriteLine(point);
    }

    private static void BuilderPatternExercise()
    {
        var codeBuilder = new CodeBuilder("Person")
            .AddField("Name", "string")
            .AddField("Age", "int");

        Console.WriteLine(codeBuilder);
    }

    private static void CreatePersonWithFacetedBuilder()
    {
        Person person = Person.PersonFacetedBuilder()
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
                .SetZipCode("10473");
        
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