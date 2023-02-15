using Patterns.Creational.FactoryMethod.Example_003.Products;

namespace Patterns.Creational.FactoryMethod.Example_003.Creators;

public abstract class Creator
{
    public Product? Product { get; set; }

    protected abstract Product CreateProduct();

    public virtual Product Create() => 
        Product = CreateProduct();

    public virtual void AnOperation()
    {
        Product ??= CreateProduct();
        Console.WriteLine(Product.ToString());
    }
}