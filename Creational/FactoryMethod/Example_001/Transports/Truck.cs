namespace Patterns.Creational.FactoryMethod.Example_001.Transports;

public class Truck : Transport
{
    public override void Load() =>
        Console.WriteLine($"{nameof(Truck)} - {nameof(Load)}");

    public override void Go() =>
        Console.WriteLine($"{nameof(Truck)} - {nameof(Go)}");

    public override void Unload() =>
        Console.WriteLine($"{nameof(Truck)} - {nameof(Unload)}");
}