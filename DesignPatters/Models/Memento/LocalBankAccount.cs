namespace DesignPatters.Models.Memento;

public class LocalBankAccount
{
    private readonly List<Memento> _changes = [];
    private int _current;

    private int _balance;
    
    public LocalBankAccount(int balance)
    {
        _balance = balance;
        _changes.Add(new Memento(_balance));
    }

    public Memento Deposit(int amount)
    {
        _balance += amount;
        var m = new Memento(_balance);
        _changes.Add(m);
        _current++;
        return m;
    }
    
    public Memento? Restore(Memento? memento)
    {
        if (memento is not null)
        {
            _balance = memento.Balance;
            _changes.Add(memento);
            _current++;
            return memento;
        }

        return null;
    }

    public Memento? Undo()
    {
        if (_current > 0)
        {
            _current -= 1;
            var m = _changes[_current];
            _balance = m.Balance;
            return m;
        }
        
        return null;
    }

    public Memento Redo()
    {
        if ((_current + 1) < _changes.Count)
        {
            _current += 1;
            var m = _changes[_current];
            _balance = m.Balance;
            return m;
        }
        
        return null;
    }

    public override string ToString()
    {
        return $"{nameof(_balance)}: {_balance}";
    }
}