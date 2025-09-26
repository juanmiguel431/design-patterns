using Newtonsoft.Json;

namespace DesignPatters.Models.Persons;

public static class ExtensionMethods
{
    public static T DeepClone<T>(this T item)
        where T : IDeepCopyable<T>, new()
    {
        return item.DeepClone();
    }
    
    public static T CloneWithSerialization<T>(this T self)
    {
        var json = JsonConvert.SerializeObject(self);
        return JsonConvert.DeserializeObject<T>(json)!;
    }
}