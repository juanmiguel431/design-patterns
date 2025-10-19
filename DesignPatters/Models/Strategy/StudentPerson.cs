namespace DesignPatters.Models.Strategy;

public class StudentPerson : IComparable<StudentPerson>
{
    public int CompareTo(StudentPerson? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (other is null) return 1;
        return Id.CompareTo(other.Id);
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public StudentPerson(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
    }

    private sealed class NameRelationalComparer : IComparer<StudentPerson>
    {
        public int Compare(StudentPerson? x, StudentPerson? y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (y is null) return 1;
            if (x is null) return -1;
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }

    public static IComparer<StudentPerson> NameComparer { get; } = new NameRelationalComparer();
    
    
}