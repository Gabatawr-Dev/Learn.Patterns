using System.Drawing;

namespace Patterns.Creational.Prototype.Example_001;

internal class Program
{
    static void Main(string[] args)
    {
        var small = 3;
        var midle = 5;
        var big = 8;

        var bigRed = new Circle(big, Color.Red);
        var middleGreen = new Circle(midle, Color.Green);
        var smallBlue = new Circle(small, Color.Blue);

        Console.WriteLine(bigRed);
        Console.WriteLine(middleGreen);
        Console.WriteLine(smallBlue);
        Console.WriteLine();

        var smallLightBlue = smallBlue.Clone();
        Console.Write("Clone: ");
        Console.WriteLine(smallLightBlue);

        Console.Write("Change: ");
        smallLightBlue.Color = Color.LightBlue;
        Console.WriteLine(smallLightBlue);
    }
}