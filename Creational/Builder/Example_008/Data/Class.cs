using System.Text;

namespace Patterns.Creational.Builder.Example_008.Data;

internal class Class
{
    public string? Name;
    public List<Field> Fields = new();

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"public class {Name}");
        sb.AppendLine("{");

        foreach (var f in Fields)
            sb.AppendLine($"  {f};");

        sb.AppendLine("}");

        return sb.ToString();
    }
}