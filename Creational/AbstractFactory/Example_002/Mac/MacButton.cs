using Patterns.Creational.AbstractFactory.Example_002.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_002.Mac;

public class MacButton : IButton
{
    public void Click() =>
        Console.WriteLine($"{nameof(MacButton)} on {nameof(Click)}");
}