namespace DesignPatters.Models.AdditionalLectures;

public static class ExtensionMethods
{
    public static T AddTo<T>(this T self, ICollection<T> collection)
    {
        collection.Add(self);
        return self;
    }
    
    public static T AddTo<T>(this T self, params ICollection<T>[] collection)
    {
        foreach (var c in collection)
            c.Add(self);
        
        return self;
    }
}