using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesignPatters.Models.ObserverPattern;

public class Market : INotifyPropertyChanged
{
    private readonly BindingList<float> _prices = [];
    public BindingList<float> Prices => _prices;
    
    private float _volatility;

    public float Volatility
    {
        get => _volatility;
        set
        {
            if (value.Equals(_volatility)) return;
            _volatility = value;
            OnPropertyChanged();
        }
    }

    public void AddPrice(float price)
    {
        _prices.Add(price);
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