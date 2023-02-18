using Autofac;
using NUnit.Framework;
using Patterns.Creational.Singleton.Example_003.Databases;

namespace Patterns.Creational.Singleton.Example_003;

[TestFixture]
public abstract class Tests<T> where T : IDatabase
{
    private ILifetimeScope _scope = null!;
    protected Repository Repository = null!;

    private readonly IContainer _container;
    protected Tests()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<T>()
            .As<IDatabase>()
            .SingleInstance();
        builder.RegisterType<Repository>();
        _container = builder.Build();
    }

    [SetUp]
    public void SetUp()
    {
        _scope = _container.BeginLifetimeScope();
        Repository = _scope.Resolve<Repository>();
    }

    [TearDown]
    public void TearDown() => _scope.Dispose();

    public abstract void TestSum();
    public abstract void TestAvg();
}

public class TestDbTests : Tests<TestDatabase>
{
    [Test]
    public override void TestSum()
    {
        var result = Repository.Sum(new[] { "a", "b", "c" });
        Assert.AreEqual(9 + 8 + 7, result);
    }

    [Test]
    public override void TestAvg()
    {
        var result = Repository.Avg(new[] { "a", "b", "c" });
        Assert.AreEqual((9 + 8 + 7) / 3d, result);
    }
}

public class DbTests : Tests<Database>
{
    [Test]
    public override void TestSum()
    {
        var result = Repository.Sum(new[] { "a", "b", "c", "d" });
        Assert.AreEqual(1 + 2 + 3 + 4, result);
    }

    [Test]
    public override void TestAvg()
    {
        var result = Repository.Avg(new[] { "a", "b", "c", "d" });
        Assert.AreEqual((1 + 2 + 3 + 4) / 4d, result);
    }
}