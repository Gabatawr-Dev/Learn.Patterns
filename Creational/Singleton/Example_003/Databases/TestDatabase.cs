namespace Patterns.Creational.Singleton.Example_003.Databases;

public class TestDatabase : AbstractDatabase
{
    protected override Dictionary<string, int> InitSet() => new()
    {
        { "a", 9 },
        { "b", 8 },
        { "c", 7 },
    };
}