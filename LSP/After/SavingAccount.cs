namespace LSP.After;

public class SavingAccount(string? name, decimal balance)
    : RegularAccount(name, balance)
{
    public override void Deposit(decimal amount)
        => Balance += amount;

    public override void WithDraw(decimal amount)
        => Balance -= amount;
}
