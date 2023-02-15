namespace Patterns.Creational.Prototype.Example_001;

public interface ICloneable<out T> : ICloneable
{
    public new T Clone();
    object ICloneable.Clone() => Clone()!;
}