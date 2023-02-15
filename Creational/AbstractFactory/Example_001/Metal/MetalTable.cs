using Patterns.Creational.AbstractFactory.Example_001.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_001.Metal;

public class MetalTable : ITable
{
    public void Eat() => 
        Console.Write($"{nameof(Eat)} on {nameof(MetalTable)}");
}