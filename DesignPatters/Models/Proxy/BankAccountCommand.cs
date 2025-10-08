namespace DesignPatters.Models.Proxy;

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