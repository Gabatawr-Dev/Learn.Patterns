namespace Patterns.Creational.Prototype.Example_003.Data;

public class Address
{
    public string? City, Street;

    public override string ToString() => $"{Street}, {City}";
}