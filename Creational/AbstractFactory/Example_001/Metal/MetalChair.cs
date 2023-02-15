using Patterns.Creational.AbstractFactory.Example_001.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_001.Metal;

public class MetalChair : IChair
{
    public void Sit() => 
        Console.Write($"{nameof(Sit)} on {nameof(MetalChair)}");
}