namespace LSP.Before;
public class CheckingAccount(string? name, decimal balance)
    : Account(name, balance)
{
    public override void Deposit(decimal amount) => Balance += amount;

    public override void WithDraw(decimal amount)
    {
        if (amount > 1000)
        {
            Console.WriteLine("You cannot withdraw more than $1000");
            return;
        }
        else
            Balance -= amount;
    }
}
