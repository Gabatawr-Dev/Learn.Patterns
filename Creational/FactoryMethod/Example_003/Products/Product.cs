namespace Patterns.Creational.FactoryMethod.Example_003.Products;

public abstract class Product
{
    public override string ToString() =>
        $"is base {nameof(Product)}";
}