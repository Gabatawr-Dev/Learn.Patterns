using Patterns.Creational.AbstractFactory.Example_001.Interfaces;
using Patterns.Creational.AbstractFactory.Example_001.Metal;
using Patterns.Creational.AbstractFactory.Example_001.Wood;

namespace Patterns.Creational.AbstractFactory.Example_001;

internal class Program
{
    private static void Main(string[] args)
    {
        OpenTavern(new MetalFactory());
        OpenTavern(new WoodFactory());
        Console.ReadKey();
    }

    private static void OpenTavern(IFactory factory)
    {
        Console.WriteLine($"** {nameof(Tavern)} with {factory.GetType().Name} **\n");
        var tavernW = new Tavern(factory);
        foreach (var persons in GetRandomGroups())
            tavernW.Snack(persons);
    }

    private static readonly Random Rand = new(DateTime.Now.Millisecond);
    private static IEnumerable<int> GetRandomGroups()
    {
        var groups = new int[Rand.Next(3, 7)];
        for (var i = 0; i < groups.Length; i++)
            groups[i] = Rand.Next(1, 13);
        
        return groups;
    }
}