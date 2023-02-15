namespace Patterns.Creational.FactoryMethod.Example_001.Transports;

public class Ship : Transport
{
    public override void Load() =>
        Console.WriteLine($"{nameof(Ship)} - {nameof(Load)}");

    public override void Go() =>
        Console.WriteLine($"{nameof(Ship)} - {nameof(Go)}");

    public override void Unload() =>
        Console.WriteLine($"{nameof(Ship)} - {nameof(Unload)}");
}