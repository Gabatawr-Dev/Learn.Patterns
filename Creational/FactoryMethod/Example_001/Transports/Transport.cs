namespace Patterns.Creational.FactoryMethod.Example_001.Transports;

public abstract class Transport
{
    public abstract void Load();
    public abstract void Go();
    public abstract void Unload();
}