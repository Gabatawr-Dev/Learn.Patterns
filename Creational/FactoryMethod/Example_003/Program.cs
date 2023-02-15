using Patterns.Creational.FactoryMethod.Example_003.Creators;

namespace Patterns.Creational.FactoryMethod.Example_003;

internal class Program
{
    private static void Main(string[] args)
    {
        var creator = new ConcreteCreator();
        creator.Create();
        creator.AnOperation();

        Console.ReadKey();
    }
}