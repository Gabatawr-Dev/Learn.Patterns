namespace Patterns.Creational.Singleton.Example_003.Databases;

public abstract class AbstractDatabase : IDatabase
{
    protected readonly Dictionary<string, int> Set;

    protected AbstractDatabase() => Set = InitSet();

    protected abstract Dictionary<string, int> InitSet();

    public int Sum(IEnumerable<string> keys)
    {
        var list = keys.ToList();
        return Set.Where(kvp => list.Contains(kvp.Key))
            .Sum(kvp => kvp.Value);
    }

    public double Avg(IEnumerable<string> keys)
    {
        var list = keys.ToList();
        return Set.Where(kvp => list.Contains(kvp.Key))
            .Average(kvp => kvp.Value);
    }
}