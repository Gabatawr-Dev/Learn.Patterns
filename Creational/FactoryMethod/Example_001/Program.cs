using Patterns.Creational.FactoryMethod.Example_001.Logistics;

namespace Patterns.Creational.FactoryMethod.Example_001;

internal class Program
{
    private static void Main(string[] args)
    {
        var road = new RoadLogistic();
        road.Delivery();

        var sea = new SeaLogistic();
        sea.Delivery();

        Console.ReadKey();
    }
}