using System.Xml.Serialization;

namespace Patterns.Creational.Prototype.Example_002;

public static class Extensions
{
    /// <summary>
    /// Create a deep copy of an object. Type must be serializable!
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public static T? DeepCopy<T>(this T obj)
    {
        if (typeof(T).IsSerializable is false)
            throw new ArgumentException("Type must be serializable");

        if (obj == null)
            return default;

        using var stream = new MemoryStream();
        var serializer = new XmlSerializer(typeof(T));
        serializer.Serialize(stream, obj);
        return (T)serializer.Deserialize(stream)!;
    }
}