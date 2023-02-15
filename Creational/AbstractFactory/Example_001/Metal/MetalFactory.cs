using Patterns.Creational.AbstractFactory.Example_001.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_001.Metal;

public class MetalFactory : IFactory
{
    public IChair CreateChair() => new MetalChair();
    public ITable CreateTable() => new MetalTable();
}