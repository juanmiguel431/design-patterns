using Autofac;
using DesignPatters.Models;
using DesignPatters.Models.Singleton;

namespace DesignPatternTests;

[TestFixture]
public class SingletonDatabaseTests
{
    [Test]
    public void IsSingletonTest()
    {
        var db1 = SingletonDatabase.Instance;
        var db2 = SingletonDatabase.Instance;

        Assert.That(db1, Is.EqualTo(db2));
        Assert.That(db1, Is.SameAs(db2));
        Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
    }

    [Test]
    public void SingletonTotalPopulationTest()
    {
        var rf = new SingletonRecordFinder();
        var names = new string[] {"Seoul", "Mexico City"};
        var total = rf.GetTotalPopulationAsync(names);
        Assert.That(total, Is.EqualTo(34900000));
    }

    [Test]
    public void ConfigurableTotalPopulationTest()
    {
        var rf = new ConfigurableRecordFinder(new DummyDatabase());
        var names = new string[] {"Alpha", "Gamma"};
        var total = rf.GetTotalPopulationAsync(names);
        Assert.That(total, Is.EqualTo(4));
    }

    [Test]
    public async Task DiPopulationTest()
    {
        var cb = new ContainerBuilder();

        var ordinary = await OrdinaryDatabase.Instance;
        
        cb.RegisterInstance(ordinary)
            .As<IDatabase>()
            .SingleInstance();
        cb.RegisterType<ConfigurableRecordFinder>();

        await using var container = cb.Build();
        var rf = container.Resolve<ConfigurableRecordFinder>();
        var names = new string[] {"Seoul", "Mexico City"};
        var total = rf.GetTotalPopulationAsync(names);
        Assert.That(total, Is.EqualTo(34900000));
    }
}