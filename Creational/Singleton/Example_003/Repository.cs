using Patterns.Creational.Singleton.Example_003.Databases;

namespace Patterns.Creational.Singleton.Example_003;

public class Repository
{
    private readonly IDatabase _database;
    public Repository(IDatabase database) => 
        _database = database;

    public int Sum(IEnumerable<string> keys) => _database.Sum(keys);
    public double Avg(IEnumerable<string> keys) => _database.Avg(keys);
}