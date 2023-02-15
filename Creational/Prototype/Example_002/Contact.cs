namespace Patterns.Creational.Prototype.Example_002;

[Serializable]
public class Contact
{
    public string? Name;
    public Address? WorkAddress;

    public override string ToString() =>
        $"{nameof(Name)}: {Name}, {nameof(WorkAddress)}: {WorkAddress}";
}