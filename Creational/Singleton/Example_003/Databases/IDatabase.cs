namespace Patterns.Creational.Singleton.Example_003.Databases;

public interface IDatabase
{
    public int Sum(IEnumerable<string> keys);
    public double Avg(IEnumerable<string> keys);
}