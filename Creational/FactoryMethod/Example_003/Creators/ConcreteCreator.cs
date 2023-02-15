using Patterns.Creational.FactoryMethod.Example_003.Products;

namespace Patterns.Creational.FactoryMethod.Example_003.Creators;

public class ConcreteCreator : Creator
{
    protected override Product CreateProduct() =>
        new ConcreteProduct();
}