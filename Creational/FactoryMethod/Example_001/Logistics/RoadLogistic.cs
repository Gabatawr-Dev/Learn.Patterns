using Patterns.Creational.FactoryMethod.Example_001.Transports;

namespace Patterns.Creational.FactoryMethod.Example_001.Logistics;

public class RoadLogistic : Logistic
{
    protected override Transport CreateTransport() =>
        new Truck();
}