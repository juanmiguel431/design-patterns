namespace DesignPatters.Models.Proxy;

public interface IBankAccount
{
    void Deposit(decimal amount);
    bool Withdraw(decimal amount);
    string ToString();
}