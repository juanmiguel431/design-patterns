namespace DesignPatters.Models.Animals;

public static class ExtensionMethods
{
    public static void Crawl(this IReptile reptile)
    {
        reptile.Crawl();
    }
    
    public static void Fly(this IAvian avian)
    {
        avian.Fly();
    }
}