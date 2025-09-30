using System.Collections;

namespace DesignPatters.Models.Composite;

public class SingleValue : IValueContainer
{
    public int Value { get; set; }
    
    public IEnumerator<int> GetEnumerator()
    {
        yield return Value;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}