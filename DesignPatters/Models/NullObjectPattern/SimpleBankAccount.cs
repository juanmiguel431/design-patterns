using JetBrains.Annotations;

namespace DesignPatters.Models.NullObjectPattern;

public class SimpleBankAccount
{
    ILog _log;
    private int _balance;
    public SimpleBankAccount(ILog log)
    {
        _log = log;
        // _log = log ?? throw new ArgumentNullException(nameof(log));
    }
    
    public void Deposit(int amount)
    {
        _balance += amount;
        var result = _log.Info($"Deposited ${amount}, balance is now ${_balance}");

        Console.WriteLine("Deposited");
    }
}