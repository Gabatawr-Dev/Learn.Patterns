namespace Patterns.Creational.Builder.Example_008.Data;

internal class Field
{
    public string? Type, Name;

    public override string ToString() =>
        $"public {Type} {Name}";
}