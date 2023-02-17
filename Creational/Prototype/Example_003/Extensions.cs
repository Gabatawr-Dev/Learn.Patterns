using System.Text.Json;

namespace Patterns.Creational.Prototype.Example_003;

public static class Extensions
{
    private static readonly JsonSerializerOptions _deepCloneOptions = new()
    {
        IncludeFields = true
    };

    /// <exception cref="NotSupportedException"></exception>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="JsonException"></exception>
    public static T? DeepCopy<T>(this T @this, JsonSerializerOptions? options = null)
    {
        var data = JsonSerializer.Serialize(@this, options ?? _deepCloneOptions);
        return JsonSerializer.Deserialize<T>(data, options ?? _deepCloneOptions);
    }
}