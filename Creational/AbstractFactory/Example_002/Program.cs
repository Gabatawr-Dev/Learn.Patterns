using Patterns.Creational.AbstractFactory.Example_002.Interfaces;
using Patterns.Creational.AbstractFactory.Example_002.Win;

namespace Patterns.Creational.AbstractFactory.Example_002;

internal class Program
{
    private static void Main(string[] args)
    {
        IFactory factory = new WinFactory();

        var window = factory.CreateWindow();
        var scrollBar = factory.CreateScrollBar();
        var button = factory.CreateButton();

        button.Click();
        scrollBar.Move();
        window.Close();

        Console.ReadKey();
    }
}