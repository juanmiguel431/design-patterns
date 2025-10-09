namespace DesignPatters.Models.Proxy;

public class CompositeBankAccountCommand: List<BankAccountCommand>, IUserCommand
{
    public CompositeBankAccountCommand()
    {
    }

    public CompositeBankAccountCommand(IEnumerable<BankAccountCommand> collection) : base(collection)
    {
    }

    public CompositeBankAccountCommand(int capacity) : base(capacity)
    {
    }

    public virtual void Execute()
    {
        ForEach(cmd => cmd.Execute());
    }

    public virtual void Undo()
    {
        foreach (var cmd in Enumerable.Reverse(this))
        {
            if (!cmd.Success) continue;
            cmd.Undo();
        }
    }

    public virtual bool Success
    {
        get => this.All(cmd => cmd.Success);
        set
        {
            foreach (var cmd in this)
            {
                cmd.Success = value;
            }
        }
    }
}