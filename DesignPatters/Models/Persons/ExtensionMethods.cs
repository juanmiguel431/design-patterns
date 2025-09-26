namespace DesignPatters.Models.Persons;

public static class ExtensionMethods
{
    public static T DeepClone<T>(this IDeepCopyable<T> item)
        where T : new()
    {
        return item.DeepClone();
    }
}