using Autofac;
using NUnit.Framework;
using Patterns.Creational.Singleton.Example_003.Databases;

namespace Patterns.Creational.Singleton.Example_003;

[TestFixture]
public abstract class Tests<T> where T : IDatabase
{
    protected readonly IContainer Container;
    protected Repository Repository => Container.Resolve<Repository>();
    
    protected Tests()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<T>()
            .As<IDatabase>()
            .SingleInstance();
        builder.RegisterType<Repository>();
        Container = builder.Build();
    }

    public abstract void TestSum();
}

public class TestDbTests : Tests<TestDatabase>
{
    [Test]
    public override void TestSum()
    {
        var sum = Repository.Sum(new[] { "a", "b", "c" });
        Assert.AreEqual(9 + 8 + 7, sum);
    }
}

public class DbTests : Tests<Database>
{
    [Test]
    public override void TestSum()
    {
        var sum = Repository.Sum(new[] { "a", "b", "c", "d" });
        Assert.AreEqual(1 + 2 + 3 + 4, sum);
    }
}