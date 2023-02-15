using Patterns.Creational.FactoryMethod.Example_001.Transports;

namespace Patterns.Creational.FactoryMethod.Example_001.Logistics;

public abstract class Logistic
{
    protected abstract Transport CreateTransport();

    public void Delivery()
    {
        var transport = CreateTransport();

        transport.Load();
        transport.Go();
        transport.Unload();
    }
}