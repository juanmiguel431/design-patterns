namespace DesignPatters.Models.Persons;

public static class ExtensionMethods
{
    public static T DeepClone<T>(this T item)
        where T : IDeepCopyable<T>, new()
    {
        return item.DeepClone();
    }
}