using Patterns.Creational.AbstractFactory.Example_002.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_002.Win;

public class WinButton : IButton
{
    public void Click() =>
        Console.WriteLine($"{nameof(WinButton)} on {nameof(Click)}");
}