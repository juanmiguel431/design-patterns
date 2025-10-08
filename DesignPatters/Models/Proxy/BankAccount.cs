namespace DesignPatters.Models.Proxy;

public class BankAccount : IBankAccount
{
    private int _balance;
    private const int OverdraftLimit = -500;

    public void Deposit(int amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited ${amount}, balance is now {_balance}");
    }

    public bool Withdraw(int amount)
    {
        if (_balance - amount < OverdraftLimit)
        {
            Console.WriteLine("Insufficient funds");
            return false;
        }

        _balance -= amount;
        Console.WriteLine($"Withdrew ${amount}, balance is now {_balance}");
        return true;
    }

    public override string ToString()
    {
        return $"Balance: ${_balance}";
    }
}