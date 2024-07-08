namespace LSP.Before;

public class FixedDepositAccount(string? name, decimal balance)
    : Account(name, balance)
{
    public override void Deposit(decimal amount) => Balance += amount;

    public override void WithDraw(decimal amount)
        => throw new NotImplementedException();
}
