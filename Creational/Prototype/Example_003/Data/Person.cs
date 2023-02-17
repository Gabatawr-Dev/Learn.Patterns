namespace Patterns.Creational.Prototype.Example_003.Data;

public class Person
{
    public string? Name;
    public Address? Address;

    public override string ToString() => $"{Name} lives at {Address}";
}