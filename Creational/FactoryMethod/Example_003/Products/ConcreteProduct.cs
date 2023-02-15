namespace Patterns.Creational.FactoryMethod.Example_003.Products;

public class ConcreteProduct : Product
{
    public override string ToString() =>
        $"is {nameof(ConcreteProduct)}";
}