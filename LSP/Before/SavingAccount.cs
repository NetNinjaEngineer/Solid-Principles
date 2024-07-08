namespace LSP.Before;

public class SavingAccount(string? name, decimal balance)
    : Account(name, balance)
{
    public override void Deposit(decimal amount)
        => Balance += amount;

    public override void WithDraw(decimal amount)
        => Balance -= amount;
}
