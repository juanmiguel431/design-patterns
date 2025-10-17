namespace DesignPatters.Models.ObserverPattern;

public class Developer : PropertyNotificationSupport
{
    public int Age
    {
        get => _age;
        set
        {
            if (value == _age) return;
            _age = value;
            OnPropertyChanged();
        }
    }
    
    // public bool CanVote => Age >= 16; // This doesn't scale well, Now its going to be used from constructor.
    private readonly Func<bool> _canVote;
    private int _age;
    public bool CanVote => _canVote();

    private bool _citizen;
    public bool Citizen
    {
        get => _citizen;
        set
        {
            if (value == _citizen) return;
            _citizen = value;
            OnPropertyChanged();
        }
    }

    public Developer()
    {
        _canVote = Property(nameof(CanVote), () => Age >= 16 && Citizen);
    }
}