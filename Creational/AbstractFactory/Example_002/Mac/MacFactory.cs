using Patterns.Creational.AbstractFactory.Example_002.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_002.Mac;

public class MacFactory : IFactory
{
    public IWindow CreateWindow() => new MacWindow();
    public IScrollBar CreateScrollBar() => new MacScrollBar();
    public IButton CreateButton() => new MacButton();
}