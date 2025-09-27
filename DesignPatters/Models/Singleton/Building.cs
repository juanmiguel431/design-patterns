namespace DesignPatters.Models.Singleton;

public class Building
{
    public List<Wall> Walls { get; set; } = [];
}

public class BuildingContext
{
    public static int WallHeight { get; set; }
}