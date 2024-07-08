namespace LSP.After;

public class FixedDepositAccount(string? name, decimal balance)
    : Account(name, balance)
{
    public override void Deposit(decimal amount) => Balance += amount;
}
