namespace Patterns.Creational.Builder.Example_005.Builders;

/// <summary><i> First in the chain of inheritance </i></summary>
public abstract class PersonBuilder
{
    protected Person Person = new();

    public Person Build() => Person;
}