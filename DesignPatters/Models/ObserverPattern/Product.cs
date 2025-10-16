using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesignPatters.Models.ObserverPattern;

public class OProduct: INotifyPropertyChanged
{
    private string _name;

    public OProduct(string name)
    {
        _name = name;
    }

    public string Name
    {
        get => _name;
        set
        {
            if (value == _name) return; // This prevents infinite loop
            _name = value;
            OnPropertyChanged();
        }
    }
    
    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}";
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}

public class OWindows : INotifyPropertyChanged
{
    private string _productName;

    public OWindows(string productName)
    {
        _productName = productName;
    }

    public override string ToString()
    {
        return $"{nameof(ProductName)}: {ProductName}";
    }

    public string ProductName
    {
        get => _productName;
        set
        {
            if (value == _productName) return; // This prevents infinite loop
            _productName = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}