using Patterns.Creational.AbstractFactory.Example_002.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_002.Mac;

public class MacScrollBar : IScrollBar
{
    public void Move() =>
        Console.WriteLine($"{nameof(MacScrollBar)} on {nameof(Move)}");
}