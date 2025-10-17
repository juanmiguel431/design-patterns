using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesignPatters.Models.ObserverPattern;

public class Engineer : INotifyPropertyChanged
{
    private int _age;

    public int Age
    {
        get => _age;
        set
        {
            // 4-5
            // var oldCanVote = CanVote;
            
            
            if (value == _age) return;
            _age = value;
            OnPropertyChanged();

            // This doesn't scale well
            // if (oldCanVote != CanVote)
            // {
            //     OnPropertyChanged(nameof(CanVote));
            // }
        }
    }

    public bool CanVote => Age >= 16;
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