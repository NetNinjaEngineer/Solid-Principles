namespace LSP.After
{
    public abstract class Account(string? name, decimal balance)
    {
        public string? Name { get; set; } = name;
        public decimal Balance { get; set; } = balance;

        public abstract void Deposit(decimal amount);

    }
}
