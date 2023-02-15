using Patterns.Creational.AbstractFactory.Example_002.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_002.Win;

public class WinScrollBar : IScrollBar
{
    public void Move() => 
        Console.WriteLine($"{nameof(WinScrollBar)} on {nameof(Move)}");
}