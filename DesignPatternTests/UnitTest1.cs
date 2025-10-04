using DesignPatters.Models.Flyweight;
using JetBrains.dotMemoryUnit;

namespace DesignPatternTests;

public class Tests
{

    [Test]
    public void Test()
    {
        var f = "Juan Miguel";
        
        var f2 = new string(f.ToCharArray());
        
        var same = object.ReferenceEquals(f, f2);
        
        Assert.That(f, Is.SameAs(f2));
    }


    [Test]
    public void TestUser() // 31,286,846 vs 23,330,166
    {
        var firstNames = Enumerable.Range(0, 500).Select(x => RandomString()).ToList();
        var lastNames = firstNames.Select(x => new string(x.ToCharArray())).ToList();
        
        var users = new List<User>();
        foreach (var firstName in firstNames)
        foreach (var lastName in lastNames)
            users.Add(new User($"{firstName} {lastName}"));
        
        ForceGC();

        dotMemory.Check(memory =>
        {
            Console.WriteLine(memory.SizeInBytes);
        });
    }
    
    [Test]
    public void TestUser2() // 23,330,166 vs 31,286,846
    {
        var firstNames = Enumerable.Range(0, 500).Select(x => RandomString()).ToList();
        var lastNames = firstNames.Select(x => new string(x.ToCharArray())).ToList();
        
        var users = new List<User2>();
        foreach (var firstName in firstNames)
        foreach (var lastName in lastNames)
            users.Add(new User2($"{firstName} {lastName}"));
        
        ForceGC();

        dotMemory.Check(memory =>
        {
            Console.WriteLine(memory.SizeInBytes);
        });
    }

    private void ForceGC()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }

    private static string RandomString()
    {
        var random = new Random();
        var randomNumbers = Enumerable.Range(0, 10).Select(i =>
        {
            var randomNumber = 'a' + random.Next(26);
            return (char)randomNumber;
        }).ToArray();
        
        return new string(randomNumbers);
    }
}