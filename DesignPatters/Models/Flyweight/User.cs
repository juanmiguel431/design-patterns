namespace DesignPatters.Models.Flyweight;

public class User
{
    public string FullName { get; set; }
    
    public User(string fullName)
    {
        FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
    }
}

public class User2
{
    private static readonly List<string> Strings = new();
    private readonly int[] _names;

    public User2(string fullName)
    {
        _names = fullName.Split(' ').Select(GetOrAdd).ToArray();
    }

    private static int GetOrAdd(string s)
    {
        var index = Strings.IndexOf(s);
        if (index != -1) return index;
            
        Strings.Add(s);
        return Strings.Count - 1;
    }
    
    public string FullName => string.Join(' ', _names.Select(i => Strings[i]).ToArray());
}