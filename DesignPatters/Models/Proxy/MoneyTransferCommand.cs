namespace DesignPatters.Models.Proxy;

public class MoneyTransferCommand : CompositeBankAccountCommand
{
    public MoneyTransferCommand(BankAccount from, BankAccount to, decimal amount)
    {
        AddRange(new []
        {
            new BankAccountCommand(from, BankAccountCommand.Action.Withdraw, amount),
            new BankAccountCommand(from, BankAccountCommand.Action.Withdraw, amount * 0.05M),
            new BankAccountCommand(to, BankAccountCommand.Action.Deposit, amount),
        });
    }
    
    public override void Execute()
    {
        foreach (var command in this)
        {
            command.Execute();
            if (command.Success) continue;
            
            Undo();
            break;
        }
        
    }
}