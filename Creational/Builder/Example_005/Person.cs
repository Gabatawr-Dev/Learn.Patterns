using Patterns.Creational.Builder.Example_005.Builders;
using System.Text;

namespace Patterns.Creational.Builder.Example_005;

public class Person
{
    public string? Name, Position;

    public DateTime DateOfBirth;

    public override string ToString()
    {
        var sb = new StringBuilder();
        const int pr = 14;

        sb.AppendLine($"{nameof(Name).PadRight(pr)}: {Name}");
        sb.AppendLine($"{nameof(Position).PadRight(pr)}: {Position}");
        sb.AppendLine($"{nameof(DateOfBirth).PadRight(pr)}: {DateOfBirth}");

        return sb.ToString();
    }

    public static Builder New => new();

    /// <summary><i> Last in the chain of inheritance </i></summary>
    public class Builder : PersonBirthDateBuilder<Builder>
    {
        internal Builder() { }
    }
}