using Patterns.Creational.AbstractFactory.Example_002.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_002.Win;

public class WinFactory : IFactory
{
    public IWindow CreateWindow() => new WinWindow();
    public IScrollBar CreateScrollBar() => new WinScrollBar();
    public IButton CreateButton() => new WinButton();
}