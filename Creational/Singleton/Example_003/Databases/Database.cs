using MoreLinq;

namespace Patterns.Creational.Singleton.Example_003.Databases;

public class Database : AbstractDatabase
{
    private const string DATA_FILE = "data.txt";

    protected override Dictionary<string, int> InitSet()
    {
        var dir = new FileInfo(typeof(Database).Assembly.Location)
            .DirectoryName!;
        var path = Path.Combine(dir, DATA_FILE);
        if (File.Exists(path) is false)
            throw new FileNotFoundException($"File {path} not found");

        return File.ReadAllLines(path)
            .Batch(2)
            .ToDictionary(
                list => list.First().Trim(),
                list => int.Parse(list.Last().Trim()));
    }
}