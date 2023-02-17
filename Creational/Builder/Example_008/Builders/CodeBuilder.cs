using Patterns.Creational.Builder.Example_008.Data;

namespace Patterns.Creational.Builder.Example_008.Builders;

public class CodeBuilder
{
    private readonly Class _class = new();
    public CodeBuilder(string rootName) =>
        _class.Name = rootName;

    public CodeBuilder AddField(string name, string type)
    {
        _class.Fields.Add(new Field { Name = name, Type = type });
        return this;
    }

    public override string ToString() =>
        _class.ToString();
}