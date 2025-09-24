namespace DesignPatters.Models.Themes;

public interface ITheme
{
    string TextColor { get; }
    string BrgColor { get; }
}

public class Ref<T> where T : class
{
    public T Value { get; set; }
    
    public Ref(T value)
    {
        Value = value;
    }
}