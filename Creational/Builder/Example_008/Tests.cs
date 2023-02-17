using NUnit.Framework;
using Patterns.Creational.Builder.Example_008.Builders;

namespace Patterns.Creational.Builder.Example_008;

[TestFixture]
public class Tests
{
    private static string Unify(string s) =>
        s.Trim().Replace("\r\n", "\n");

    [Test]
    public void EmptyTest()
    {
        var cb = new CodeBuilder("Empty");
        Assert.That(Unify(cb.ToString()), Is.EqualTo(Unify(
@"public class Empty
{
}"
        )));
    }

    [Test]
    public void PersonTest()
    {
        var cb = new CodeBuilder("Person")
            .AddField("Name", "string?")
            .AddField("Age", "int");

        Assert.That(Unify(cb.ToString()), Is.EqualTo(Unify(
@"public class Person
{
  public string? Name;
  public int Age;
}"
        )));
    }
}