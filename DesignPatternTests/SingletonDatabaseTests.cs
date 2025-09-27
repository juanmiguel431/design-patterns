using DesignPatters.Models;

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
}