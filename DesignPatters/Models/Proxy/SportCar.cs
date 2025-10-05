namespace DesignPatters.Models.Proxy;

public interface ISportCar
{
    void Drive();
}

public class SportCar : ISportCar
{
    public void Drive()
    {
        Console.WriteLine("The car is being driven");
    }
}

public class SportCarProxy : ISportCar
{
    private readonly Driver _driver;
    private readonly SportCar _sportCar = new();
    
    public SportCarProxy(Driver driver)
    {
        _driver = driver ?? throw new ArgumentNullException(nameof(driver));
    }
    
    public void Drive()
    {
        if (_driver.Age < 18)
        {
            Console.WriteLine("Too young to drive");
            return;
        }
        
        _sportCar.Drive();
    }
}

public class Driver
{
    public int Age { get; set; }
}