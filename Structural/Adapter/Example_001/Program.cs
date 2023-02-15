namespace Patterns.Structural.Adapter.Example_001;

internal class Program
{
    static void Main(string[] args)
    {
        ISumService<int> sumService = new AdapterSum();
        var res = sumService.Sum(1, 2);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}