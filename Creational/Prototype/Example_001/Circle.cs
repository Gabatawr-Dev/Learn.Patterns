using System.Drawing;

namespace Patterns.Creational.Prototype.Example_001;

public class Circle : ICloneable<Circle>
{
    public Color Color { get; set; }

    private readonly int _radius;

    public Circle(int radius, Color? color = null)
    {
        _radius = radius;
        Color = color ?? Color.White;
    }

    public Circle Clone()
    {
        var clone = new Circle(_radius)
        {
            Color = Color
        };
        return clone;
    }

    public override string ToString() => 
        $"Circle: radius = {_radius}, color = {Color};";
}