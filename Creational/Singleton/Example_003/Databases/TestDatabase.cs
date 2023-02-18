namespace Patterns.Creational.Singleton.Example_003.Databases;

public class TestDatabase : IDatabase
{
    private readonly Dictionary<string, int> _data = new()
    {
        { "a", 9 },
        { "b", 8 },
        { "c", 7 },
    };

    public int Sum(IEnumerable<string> keys)
    {
        var list = keys.ToList();
        return _data.Where(kvp => list.Contains(kvp.Key))
            .Sum(kvp => kvp.Value);
    }
}