namespace DesignPatters.Models.Proxy;

public interface IBankAccount
{
    void Deposit(int amount);
    bool Withdraw(int amount);
    string ToString();
}

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

public interface IUserCommand
{
    public void Execute();
    public void Undo();
}

public class BankAccountCommand : IUserCommand
{
    private readonly IBankAccount _bankAccount;

    public enum Action
    {
        Deposit,
        Withdraw,
    }
    
    private readonly Action _action;
    private readonly int _amount;
    private bool _isSucceeded;
    
    public BankAccountCommand(IBankAccount bankAccount, Action action, int amount)
    {
        _bankAccount = bankAccount ?? throw new ArgumentNullException(nameof(bankAccount));
        _action = action;
        _amount = amount;
    }
    
    public void Execute()
    {
        switch (_action)
        {
            case Action.Deposit:
                _bankAccount.Deposit(_amount);
                _isSucceeded = true;
                break;
            case Action.Withdraw:
                _isSucceeded = _bankAccount.Withdraw(_amount);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void Undo()
    {
        if (!_isSucceeded) return;
        switch (_action)
        {
            case Action.Withdraw:
                _bankAccount.Deposit(_amount);
                break;
            case Action.Deposit:
                _bankAccount.Withdraw(_amount);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}