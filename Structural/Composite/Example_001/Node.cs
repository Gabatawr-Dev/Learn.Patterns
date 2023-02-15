namespace Patterns.Structural.Composite.Example_001;

public class Node : IElement
{
    public List<IElement> Children { get; }

    public Node(params IElement[] children) =>
        Children = new(children);

    public void Add(IElement element) =>
        Children.Add(element);

    public bool Remove(IElement element) =>
        Children.Remove(element);
}