namespace DesignPatters.Models.Memento;

public class LocalBankAccount
{
    public int Balance { get; set; }
    
    public LocalBankAccount(int balance)
    {
        Balance = balance;
    }

    public Memento Deposit(int amount)
    {
        Balance += amount;
        return new Memento(Balance);
    }
    
    public void Restore(Memento memento)
    {
        Balance = memento.Balance;
    }

    public override string ToString()
    {
        return $"{nameof(Balance)}: {Balance}";
    }
}

public class Memento
{
    public int Balance { get; }
    
    public Memento(int balance)
    {
        Balance = balance;
    }
}