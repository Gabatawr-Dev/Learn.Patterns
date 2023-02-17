using NUnit.Framework;
using Patterns.Creational.Prototype.Example_003.Data;

namespace Patterns.Creational.Prototype.Example_003;

[TestFixture]
public class Tests
{
    [Test]
    public void NullTest()
    {
        Person? john = null;
        var jane = john.DeepCopy();
        Assert.IsNull(jane);
    }

    [Test]
    public void NullAddressTest()
    {
        var john = new Person
        {
            Name = "John",
        };

        var jane = john.DeepCopy();
        
        Assert.IsNotNull(jane);
        Assert.IsNull(jane!.Address);
    }

    [Test]
    public void EqualsTest()
    {
        var john = new Person
        {
            Name = "John",
            Address = new Address
            {
                City = "London",
                Street = "123"
            }
        };

        var jane = john.DeepCopy();
        Assert.IsNotNull(jane);
        Assert.That(john.ToString(), Is.EqualTo(jane!.ToString()));
    }
}