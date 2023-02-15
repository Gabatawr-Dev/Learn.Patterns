using System.Drawing;

namespace Patterns.Creational.FactoryMethod.Example_001;

public class Circle : ICloneable
{
    public Color Color { get; set; }

    private readonly int _radius;

    public Circle(int radius, Color? color = null)
    {
        _radius = radius;
        Color = color ?? Color.White;
    }

    public object Clone()
    {
        var clone = new Circle(_radius)
        {
            Color = Color
            // Any
        };
        return clone;
    }
}