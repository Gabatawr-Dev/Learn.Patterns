using Patterns.Creational.AbstractFactory.Example_002.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_002.Mac;

public class MacWindow : IWindow
{
    public void Close() =>
        Console.WriteLine($"{nameof(MacWindow)} on {nameof(Close)}");
}