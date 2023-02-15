using Patterns.Creational.AbstractFactory.Example_001.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_001.Wood;

public class WoodChair : IChair
{
    public void Sit() => 
        Console.Write($"{nameof(Sit)} on {nameof(WoodChair)}");
}