using System.Xml.Serialization;
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
    
    public static T CloneWithXml<T>(this T self)
    {
        using var ms = new MemoryStream();
        var xmlSerializer = new XmlSerializer(typeof(T));
        xmlSerializer.Serialize(ms, self);
        ms.Position = 0;
        return (T)xmlSerializer.Deserialize(ms);
    }
}