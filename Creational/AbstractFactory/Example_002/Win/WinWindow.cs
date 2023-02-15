using Patterns.Creational.AbstractFactory.Example_002.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_002.Win;

public class WinWindow : IWindow
{
    public void Close() => 
        Console.WriteLine($"{nameof(WinWindow)} on {nameof(Close)}");
}