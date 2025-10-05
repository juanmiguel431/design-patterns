using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesignPatters.Models.Proxy;

// MVVM

// Model
public class DeveloperPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public DeveloperPerson(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}";
    }
}

// View



// ViewModel
public class DeveloperPersonViewModel : INotifyPropertyChanged
{
    private readonly DeveloperPerson _person;
    
    public string FirstName
    {
        get => _person.FirstName;
        set
        {
            if (_person.FirstName == value) return;
            _person.FirstName = value;
            OnPropertyChanged(nameof(FirstName));
            OnPropertyChanged(nameof(FullName));
        }
    }

    public string LastName
    {
        get => _person.LastName;
        set
        {
            if (_person.LastName == value) return;
            _person.LastName = value;
            OnPropertyChanged(nameof(LastName));
            OnPropertyChanged(nameof(FullName));
        }
    }

    public string FullName
    {
        get => $"{FirstName} {LastName}".Trim();
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                FirstName = LastName = null;
                return;
            }
            
            var items = value.Split(' ');
            if (items.Length > 0)
            {
                FirstName = items[0];
            }
            
            if (items.Length > 1)
            {
                LastName = items[1];
            }
        }
    }

    public DeveloperPersonViewModel(DeveloperPerson person)
    {
        _person = person;
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