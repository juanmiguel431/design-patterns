namespace DesignPatters.Models.Proxy;

public class BankAccount : IBankAccount
{
    private readonly string _name;
    private decimal _balance;
    private const decimal OverdraftLimit = -500;

    public BankAccount(string name = "Unnamed")
    {
        _name = name;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"{_name} - Deposited ${amount}, balance is now ${_balance}");
    }

    public bool Withdraw(decimal amount)
    {
        if (_balance - amount < OverdraftLimit)
        {
            Console.WriteLine($"{_name} - Insufficient funds");
            return false;
        }

        _balance -= amount;
        Console.WriteLine($"{_name} - Withdrew ${amount}, balance is now ${_balance}");
        return true;
    }

    public override string ToString()
    {
        return $"{_name} - Balance: ${_balance}";
    }
}