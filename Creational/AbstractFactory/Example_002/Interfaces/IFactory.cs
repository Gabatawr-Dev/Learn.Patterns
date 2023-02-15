namespace Patterns.Creational.AbstractFactory.Example_002.Interfaces;

public interface IFactory
{
    public IWindow CreateWindow();
    public IScrollBar CreateScrollBar();
    public IButton CreateButton();
}