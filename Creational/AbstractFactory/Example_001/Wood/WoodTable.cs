using Patterns.Creational.AbstractFactory.Example_001.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_001.Wood;

public class WoodTable : ITable
{
    public void Eat() =>
        Console.Write($"{nameof(Eat)} on {nameof(WoodTable)}");
}