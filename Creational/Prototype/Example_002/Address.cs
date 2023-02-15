namespace Patterns.Creational.Prototype.Example_002;

[Serializable]
public class Address
{
    public string? City;
    public string? Street;
    public int? Suite;

    public override string ToString() =>
        $"{nameof(City)}: {City}, {nameof(Street)}: {Street}, {nameof(Suite)}: {Suite}";
}