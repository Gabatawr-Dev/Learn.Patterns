using MoreLinq;

namespace Patterns.Creational.Singleton.Example_003.Databases;

public class Database : IDatabase
{
    private const string DATA_FILE = "data.txt";

    private readonly Dictionary<string, int> _data;

    public Database()
    {
        var dir = new FileInfo(typeof(Database).Assembly.Location)
            .DirectoryName!;
        var path = Path.Combine(dir, DATA_FILE);
        if (File.Exists(path) is false)
            throw new FileNotFoundException($"File {path} not found");

        _data = File.ReadAllLines(path)
            .Batch(2)
            .ToDictionary(
                list => list.First().Trim(),
                list => int.Parse(list.Last().Trim()));
    }


    public int Sum(IEnumerable<string> keys)
    {
        var list = keys.ToList();
        return _data.Where(kvp => list.Contains(kvp.Key))
            .Sum(kvp => kvp.Value);
    }
}