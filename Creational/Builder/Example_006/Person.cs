using System.Text;

namespace Patterns.Creational.Builder.Example_006;

public class Person
{
    public string? Name, Position;

    public override string ToString()
    {
        var sb = new StringBuilder();
        const int pr = 14;

        sb.AppendLine($"{nameof(Name).PadRight(pr)}: {Name}");
        sb.AppendLine($"{nameof(Position).PadRight(pr)}: {Position}");

        return sb.ToString();
    }
}