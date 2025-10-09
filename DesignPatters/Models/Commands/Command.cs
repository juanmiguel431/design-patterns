namespace DesignPatters.Models.Commands;

public class Command
{
    public enum Action
    {
        Deposit,
        Withdraw
    }

    public Action TheAction;
    public int Amount;
    public bool Success;
}

public class Account
{
    public int Balance { get; set; }

    public void Process(Command c)
    {
        switch (c.TheAction)
        {
            case Command.Action.Deposit:
                Balance += c.Amount;
                c.Success = true;
                break;
            case Command.Action.Withdraw:
            {
                if (c.Amount > Balance) return;
            
                Balance -= c.Amount;
                c.Success = true;
                break;
            }
        }
    }

    public override string ToString()
    {
        return $"{nameof(Balance)}: {Balance}";
    }
}

// Implement the Account.Process()  method to process different account commands. The rules are obvious:
//
// Success indicates whether the operation was successful
//     You can only withdraw money if you have enough in your account