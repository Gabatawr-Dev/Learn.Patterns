using Patterns.Creational.AbstractFactory.Example_001.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_001.Wood;

public class WoodFactory : IFactory
{
    public IChair CreateChair() => new WoodChair();
    public ITable CreateTable() => new WoodTable();
}