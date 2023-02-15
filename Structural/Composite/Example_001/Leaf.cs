namespace Patterns.Structural.Composite.Example_001;

public class Leaf : IElement
{
    public string Data { get; set; }

    public Leaf(string data) => Data = data;
}