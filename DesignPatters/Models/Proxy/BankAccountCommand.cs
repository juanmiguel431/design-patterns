namespace DesignPatters.Models.Proxy;

public class BankAccountCommand : IUserCommand
{
    private readonly IBankAccount _bankAccount;
    public bool Success { get; set; }

    public enum Action
    {
        Deposit,
        Withdraw,
    }
    
    private readonly Action _action;
    private readonly decimal _amount;
    
    public BankAccountCommand(IBankAccount bankAccount, Action action, decimal amount)
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
                Success = true;
                break;
            case Action.Withdraw:
                Success = _bankAccount.Withdraw(_amount);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void Undo()
    {
        if (!Success) return;
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

        Success = false;
    }
}